#` is the escape char in powershell. ($ and " need it in the inxml string below)
#Powershell -ExecutionPolicy Bypass -F c:"api_create_Workflow".ps1  TD_US_CustomerSourceLand_CS1



param(
 [Parameter(Mandatory=$true)][string]$New_task_name = "", [string]$User = "",[string]$Pass = "")


$newguid = [GUID]::NewGuid() -replace '-',''
$newvar = [GUID]::NewGuid() -replace '-',''
$newemail = [GUID]::NewGuid() -replace '-',''
$virtual = [GUID]::NewGuid() -replace '-',''

$inxml = "
<taskWorkflow retainSysIds=`"true`" version=`"1`">
        <actions />
        <variables />
        <notes />
        <virtualResources />
        <exclusiveTasks />
        <stepConditions />
        <stepActions />
        <runCriteria />
        <name>$New_task_name TRDATE_`${TRDATE}</name>
        <opswiseGroups><opswiseGroup>QVC US</opswiseGroup></opswiseGroups>
        <sysId>$newguid</sysId>




<virtualResources>
       <virtualResource>
             <amount>1</amount>
             <resource>TERADATA</resource>
       </virtualResource>
</virtualResources>


        

<variables>
       <variable>
                <sysId>$newvar</sysId>
                
                <name>TRDATE</name>
                <value>`${_date('EEEE MMMM dd, yyyy')}</value>
       </variable>

</variables>

</taskWorkflow>
"
 


$password = ConvertTo-SecureString $Pass -AsPlainText -Force                                                       
$mycred = new-object -typename System.Management.Automation.PSCredential -argumentlist $User,$password 
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 
$response = Invoke-RestMethod -cred $mycred -Method Post -Body $inxml -ContentType "application/xml" -URI https://u01vdaalapp0151:8443/opswise/resources/task

echo $response


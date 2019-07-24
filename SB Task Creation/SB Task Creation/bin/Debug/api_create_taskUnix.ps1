#` is the escape char in powershell. ($ and " need it in the inxml string below)

#Powershell -ExecutionPolicy Bypass -F c:"api_create_taskUnix".ps1 -New_task_name TDCustomerSourceLand_wf_m_US_DB2_CUSTOMER_WELLNESS_PARTICIPANT -New_parameters "-f TDCustomerSourceLand wf_m_US_DB2_CUSTOMER_WELLNESS_PARTICIPANT -t"

param([Parameter(Mandatory=$true)][string]$New_task_name = "", [string]$New_parameters = "", [string]$User = "",[string]$Pass = "")


$newguid = [GUID]::NewGuid() -replace '-',''

$inxml = "
 <taskUnix retainSysIds=`"true`" version=`"1`">
    <variables/>
    <notes/>
    <agent />
    <agentCluster />
    <agentClusterVar />
    <agentVar>`${AGT_VAR_U01VPTDLAPP0007}</agentVar>
    <broadcastCluster />
    <cpDuration />
    <cpDurationUnit>Minutes</cpDurationUnit>
<credentialsVar>`${teradatap}</credentialsVar>
<credentials/>
<credentialsVarCheck>true</credentialsVarCheck>
    <customField1/>
    <customField2/>
    <efDuration>00:00:00:00</efDuration>
    <efEnabled>false</efEnabled>
    <efTime>00:00</efTime>
    <efType>Time</efType>
    <holdResources>false</holdResources>
    <lfDuration>00:00:00:00</lfDuration>
    <lfEnabled>false</lfEnabled>
    <lfTime>00:00</lfTime>
    <lfType>Time</lfType>
    <lsDuration>00:00:00:00</lsDuration>
    <lsEnabled>false</lsEnabled>
    <lsType>Time</lsType>
    <name>$New_task_name</name>
    <actions/>
    <opswiseGroups/>
    <resPriority>10</resPriority>
    <retryIndefinitely>false</retryIndefinitely>
    <retryInterval>60</retryInterval>
    <retryMaximum>0</retryMaximum>
    <retrySuppressFailure>false</retrySuppressFailure>
    <startHeld>false</startHeld>
    <startHeldReason />
    <summary></summary>
    <sysId>$newguid</sysId>
    <exclusiveTasks/>
    <virtualResources/>
    <twDelayAmount />
    <twDelayDuration>00:00:00:00</twDelayDuration>
    <twDelayType>None</twDelayType>
    <twWaitAmount />
    <twWaitDayConstraint>None</twWaitDayConstraint>
    <twWaitDuration>00:00:00:00</twWaitDuration>
    <twWaitType>None</twWaitType>
    <twWorkflowOnly>-- System Default --</twWorkflowOnly>
    <userEstimatedDuration />
    <command>/informatica/cybermation/inform_launcher.sh</command>
    <commandOrScript>Command</commandOrScript>
    <environment/>
    <exitCodeOutput />
    <exitCodeProcessing>Success Exitcode Range</exitCodeProcessing>
    <exitCodeText />
    <exitCodes>0-1</exitCodes>
    <outputReturnFile />
    <outputReturnNline>100</outputReturnNline>
    <outputReturnSline>1</outputReturnSline>
    <outputReturnText />
    <outputReturnType>NONE</outputReturnType>
    <outputType>STDOUT</outputType>
    <parameters>$New_parameters</parameters>
    <retryExitCodes />
    <runAsSudo>false</runAsSudo>
    <runtimeDir />
    <script />
    <opswiseGroups><opswiseGroup>QVC US</opswiseGroup></opswiseGroups>
</taskUnix>"
 


$password = ConvertTo-SecureString $Pass -AsPlainText -Force                                                       
$mycred = new-object -typename System.Management.Automation.PSCredential -argumentlist $User,$password 
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 
$response = Invoke-RestMethod -cred $mycred -Method Post -Body $inxml -ContentType "application/xml" -URI https://u01vdaalapp0151:8443/opswise/resources/task

echo $response


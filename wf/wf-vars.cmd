set TargetFramework=netcoreapp3.1

set Dev=%ZDev%
set Wf="%Dev%\wf"
set LogRoot=%ZLogs%
set Stage=%ZLogs%
set Assets="j:\assets"
set Archive="k:\z0\archives"

set DevBuild="%Dev%\bin\lib\%TargetFramework%"
set StageBuild="%Stage%\builds\%TargetFramework%"

set ToolDir="%Assets%\tools\exe"
set LibDir="%Assets%\tools\lib"
set IncDir="%Assets%\tools\specs\headers"

set EtlLogDir="%Stage%\etl"


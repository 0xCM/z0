set SdkAppVer=netcoreapp3.0

set Dev=%ZDev%
set Stage=%ZLogs%
set Assets="j:/assets"

set Wf="%Dev%/wf"
set ToolDir="%Assets%/tools/exe"
set LibDir="%Assets%/tools/lib"
set IncDir="%Assets%/tools/specs/headers"

set DevBuild="%Dev%\bin"
set DevLib="%DevBuild%\lib\%SdkAppVer%"
set DevObj="%DevBuild%\obj"

set StageBuild="%Stage%\builds"
set StageLib="%StageBuild%\bin"
set StageObj="%StageBuild%\obj"
set StageIl="%StageBuild%\il"

set Pub="c:/Dev/pub"
set PubBuild="%Pub%\builds"
set PubIl="%Pub%\il"

set _NT_SYMBOL_PATH=srv*J:/assets/symbols*https://msdl.microsoft.com/download/symbols


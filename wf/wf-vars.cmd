set Pub="c:/Dev/pub"
set Dev=%ZDev%
set Wf="%Dev%/wf"
set Stage=%ZLogs%
set SdkAppVer=netcoreapp3.0

set DevBuildRoot="%Dev%\bin"
set StageBuildRoot="%Stage%\builds"
set PubBuildRoot="%Pub%\builds"

set DevLib="%DevBuildRoot%\lib\%SdkAppVer%"
set DevObj="%DevBuildRoot%\obj"

set StageLib="%StageBuildRoot%\bin"
set StageObj="%StageBuildRoot%\obj"

set StageIl="%Stage%\builds\il"
set PubIl="%Pub%\il"

set _NT_SYMBOL_PATH=srv*J:/assets/symbols*https://msdl.microsoft.com/download/symbols


echo off
call wf\wf-vars.cmd

set FileName=z0.binlog
set Src="%DevBuildRoot%\%FileName%"
set Dst="%StageBuildRoot%\%FileName%"
copy %Src% /A %Dst% /Y

set FileName=z0.ProjectImports.zip
set Src="%DevBuildRoot%\%FileName%"
set Dst="%StageBuildRoot%\%FileName%"
copy %Src% /A %Dst% /Y

set Src=%DevBuild%
set Dst=%StageBuild%
set Log="%EtlLogDir%\stage-build.log"
robocopy %Src% %Dst% /log:%Log% /tee /TS /BYTES /V /MIR


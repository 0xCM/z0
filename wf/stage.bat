echo off
call wf\vars.cmd

REM set FileName=z0.binlog
REM set Src="%DevBuildRoot%\%FileName%"
REM set Dst="%StageBuildRoot%\%FileName%"
REM copy %Src% /A %Dst% /Y

REM set FileName=z0.ProjectImports.zip
REM set Src="%DevBuildRoot%\%FileName%"
REM set Dst="%StageBuildRoot%\%FileName%"
REM copy %Src% /A %Dst% /Y

set SrcDir="%CodeDir%\data\content"
set DstDir="%LogRoot%\refs"
set LogPath="%ZLogs%\etl\refs-archive.log"
robocopy %SrcDir% %DstDir% /log:%LogPath% /tee /TS /BYTES /V /MIR

set Src=%DevBuild%
set Dst=%StageBuild%
set Log="%EtlLogDir%\stage-build.log"
robocopy %Src% %Dst% /log:%Log% /tee /TS /BYTES /V /MIR


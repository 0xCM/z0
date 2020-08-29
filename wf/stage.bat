echo off
call wf\vars.cmd

set SrcDir="%CodeDir%\data\content"
set DstDir="%LogRoot%\refs"
set LogPath="%ZLogs%\etl\refs-archive.log"
robocopy %SrcDir% %DstDir% /log:%LogPath% /tee /TS /BYTES /V /MIR

set Src=%DevBuild%
set Dst=%StageBuild%
set Log="%EtlLogDir%\stage-build.log"
robocopy %Src% %Dst% /log:%Log% /tee /TS /BYTES /V /MIR

set Log=%StageBuildRoot%\z0.dll.log
set Cmd=dir %Dst%\*.dll
call %Cmd% > %Log%

set Log=%StageBuildRoot%\z0.exe.log
set Cmd=dir %Dst%\*.exe
call %Cmd% > %Log%

echo off
call wf\vars.cmd

set SrcDir="%CodeDir%\data\content"
set DstDir="%LogRoot%\refs"
set LogPath="%ZLogs%\etl\refs-archive.log"

echo on
robocopy %SrcDir% %DstDir% /log:%LogPath% /tee /TS /BYTES /V /MIR
echo off

set Src=%DevBuild%
set Dst=%StageBuild%
set Log="%EtlLogDir%\stage-build.log"

echo on
robocopy %Src% %Dst% /log:%Log% /tee /TS /BYTES /V /MIR
echo off

set Log=%StageBuildRoot%\z0.dll.log
set Cmd=dir %Dst%\*.dll

echo on
call %Cmd% > %Log%
echo off

set Log=%StageBuildRoot%\z0.exe.log
set Cmd=dir %Dst%\*.exe

echo on
call %Cmd% > %Log%
echo off

set Log=%StageBuildRoot%\z0.deps.log
set Cmd=dir %ZDev%\.build\*.deps.json /s /b

echo on
call %Cmd% > %Log%


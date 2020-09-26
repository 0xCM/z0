echo off

call wf\vars.cmd
set Src=j:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64
set Dst=k:\z0\builds\nca.3.1.win-x64
set Log="%ZLogs%\etl\build-publish.log"

echo on
robocopy %Src% %Dst% /log:%Log% /tee /TS /BYTES /V /MIR

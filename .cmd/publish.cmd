echo off

set CopySrc=j:\dev\projects\z0\.build\bin\Release
echo CopySrc:%CopySrc%

set CopyDst=k:\z0\builds\release
echo CopyDst:%CopyDst%

set CopyLog=%ZDb%\etl\build-publish.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %CopySrc% %CopyDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

echo on
call %CopyCmd%

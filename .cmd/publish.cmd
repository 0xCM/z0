echo off

set CopySrc=j:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64
echo CopySrc:%CopySrc%

set CopyDst=k:\z0\builds\nca.3.1.win-x64
echo CopyDst:%CopyDst%

set CopyLog=%ZDb%\etl\build-publish.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %CopySrc% %CopyDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

echo on
call %CopyCmd%

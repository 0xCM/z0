echo off

call setup.cmd
set AddCmd=dotnet sln %SlnPath% add %ProjectPath%
echo AddCmd:%AddCmd%

echo on
call %AddCmd%

echo off

call setup.cmd
set NewSlnCmd=copy z0.project.sln %SlnPath% /y
echo NewSlnCmd:%NewSlnCmd%

echo on
call %NewSlnCmd%

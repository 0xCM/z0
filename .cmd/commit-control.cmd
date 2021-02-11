@echo off

set GitLogPath=%ZDb%\logs\git\control-git.log
echo GitLogPath:%GitLogPath%

set Sep=--------------------------------------------------------------------------------------
echo %Sep% >> %GitLogPath%

cd %ZControl%

git add -A >> %GitLogPath%
git commit -am "." >> %GitLogPath%

@echo off

set GitLogPath=%ZDb%\logs\git\db-git.log
echo GitLogPath:%GitLogPath%

set Sep=--------------------------------------------------------------------------------------
echo %Sep% >> %GitLogPath%

cd %ZDb%

git add -A >> %GitLogPath%
git commit -am "." >> %GitLogPath%

@echo off

set GitLogPath=%ZDb%\logs\git\z0-git.log
echo GitLogPath:%GitLogPath%

set Sep=--------------------------------------------------------------------------------------
echo %Sep% >> %GitLogPath%

git add -A >> %GitLogPath%
git commit -am "."  >> %GitLogPath%
git push  >> %GitLogPath%
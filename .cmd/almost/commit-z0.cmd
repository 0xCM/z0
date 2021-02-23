@echo off

set GitLogPath=%ZDb%\logs\git\z0-git.log
echo GitLogPath:%GitLogPath%

set Sep=--------------------------------------------------------------------------------------
echo %Sep% >> %GitLogPath%

cd %ZDev%

git add -A -v >> %GitLogPath%
git commit -am "." -v >> %GitLogPath%
git push -v >> %GitLogPath%

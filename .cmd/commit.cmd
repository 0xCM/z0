@echo off

set GitLogPath=%ZDb%\logs\git\git-actions.log
echo GitLogPath:%GitLogPath%

git add -A >> %GitLogPath%
git commit -am "."  >> %GitLogPath%
git push  >> %GitLogPath%
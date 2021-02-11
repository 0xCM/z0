@echo off

set RepoDir=k:\z0.archives\data
set GitLogPath=%ZDb%\logs\git\archive-git.log
echo GitLogPath:%GitLogPath%

set Sep=--------------------------------------------------------------------------------------
echo %Sep% >> %GitLogPath%


cd %RepoDir%

git add -A >> %GitLogPath%
git commit -am "." >> %GitLogPath%

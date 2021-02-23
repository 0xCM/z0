@echo off

call %~dp0\archive-z0-source-config.cmd

cd %ArchiveSrc%

git add -A -v >> %GitLogPath%
git commit -am "." -v >> %GitLogPath%
git push -v >> %GitLogPath%
git archive -v -o %ArchiveDst% HEAD 2> %ArchiveLog%
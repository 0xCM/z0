@echo off

call %~dp0\archive-control-config.cmd
cd %RepoSrc%

echo on

git add -A -v
git commit -v -am "."
git archive -v -o %RepoDst% HEAD

@echo off

set ZC=%ZControl%
echo ZC:%ZC%

set ZCmd=%ZC%\.cmd
echo ZCmd=%ZC%

call %ZCmd%\commit-z0.cmd

set Archive=%ZArchive%
set ArchiveSrc=%ZDev%
set ArchiveDst=%Archive%\bin\source\z0.zip
set ArchiveLog=%ZDb%\etl\archive-source.log
cd %ArchiveSrc%
git archive -v -o %ArchiveDst% HEAD 2> %ArchiveLog%

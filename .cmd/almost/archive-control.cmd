@echo off

set ZC=%ZControl%
echo ZC:%ZC%

set ZCmd=%ZC%\.cmd
echo ZCmd=%ZC%

call %ZCmd%\commit-control.cmd

set TargetId=z0.control
echo TargetId:%TargetId%

set Archive=%ZArchive%

set ArchiveSrc=%ZC%
echo ArchiveSrc:%ArchiveSrc%

set ArchiveDst=%Archive%\bin\source\%TargetId%.zip
echo ArchiveDst:%ArchiveDst%

set ArchiveLog=%ZDb%\etl\archive-repo-%TargetId%.log
cd %ArchiveSrc%

echo on

git archive -v -o %ArchiveDst% HEAD 2> %ArchiveLog%





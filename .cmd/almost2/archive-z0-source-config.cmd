@echo off
set Archive=%ZArchive%

set ArchiveSrc=%ZDev%
echo ArchiveSrc:%ArchiveSrc%

set ArchiveDst=%Archive%\bin\source\z0.zip
echo ArchiveDst:%ArchiveDst%

set ArchiveLog=%ZDb%\etl\archive-z0-source.log
echo ArchiveLog:%ArchiveLog%

set GitLogPath=%ZDb%\logs\git\z0-git.log
echo GitLogPath:%GitLogPath%


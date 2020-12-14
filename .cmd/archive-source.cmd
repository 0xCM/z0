@REM echo off

@REM set ArchiveDir=k:\z0.archives\data\source

@REM set DataSrc=%ZDev%\src
@REM echo DataSrc:%DataSrc%

@REM set DataDst=%ArchiveDir%\src
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\source-src-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM call %CopyCmd%

@REM set DataSrc=%ZDev%\test
@REM echo DataSrc:%DataSrc%

@REM set DataDst=%ArchiveDir%\test
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\source-test-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM call %CopyCmd%

@REM set DataSrc=%ZDev%\native
@REM echo DataSrc:%DataSrc%

@REM set DataDst=%ArchiveDir%\native
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\source-native-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM call %CopyCmd%

@REM set DataSrc=%ZDev%\.cmd
@REM echo DataSrc:%DataSrc%

@REM set DataDst=%ArchiveDir%\.cmd
@REM echo DataDst:%DataDst%

@REM set CopyLog=%ZDb%\etl\source-cmd-archive.log
@REM echo CopyLog:%CopyLog%

@REM set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
@REM echo CopyCmd:%CopyCmd%

@REM call %CopyCmd%

@REM echo on

@REM copy %ZDev%\.editorconfig /A %ArchiveDir% /Y
@REM copy %ZDev%\.gitattributes /A %ArchiveDir% /Y
@REM copy %ZDev%\.gitconfig /A %ArchiveDir% /Y
@REM copy %ZDev%\.gitignore /A %ArchiveDir% /Y
@REM copy %ZDev%\.markdownlint.json /A %ArchiveDir% /Y
@REM copy %ZDev%\directory.build.props /A %ArchiveDir% /Y
@REM copy %ZDev%\nuget.config /A %ArchiveDir% /Y
@REM copy %ZDev%\omnisharp.json /A %ArchiveDir% /Y
@REM copy %ZDev%\version /A %ArchiveDir% /Y
@REM copy %ZDev%\z0.machine.sln /A %ArchiveDir% /Y



echo off

set ArchiveDir=k:\z0.archives\data\source

set DataSrc=%ZDev%\src
echo DataSrc:%DataSrc%

set DataDst=%ArchiveDir%\src
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\source-src-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

call %CopyCmd%

set DataSrc=%ZDev%\test
echo DataSrc:%DataSrc%

set DataDst=%ArchiveDir%\test
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\source-test-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

call %CopyCmd%

set DataSrc=%ZDev%\native
echo DataSrc:%DataSrc%

set DataDst=%ArchiveDir%\native
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\source-native-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

call %CopyCmd%

set DataSrc=%ZDev%\.cmd
echo DataSrc:%DataSrc%

set DataDst=%ArchiveDir%\.cmd
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\source-cmd-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

call %CopyCmd%

echo on

copy %ZDev%\.editorconfig /A %ArchiveDir% /Y
copy %ZDev%\.gitattributes /A %ArchiveDir% /Y
copy %ZDev%\.gitconfig /A %ArchiveDir% /Y
copy %ZDev%\.gitignore /A %ArchiveDir% /Y
copy %ZDev%\.markdownlint.json /A %ArchiveDir% /Y
copy %ZDev%\directory.build.props /A %ArchiveDir% /Y
copy %ZDev%\nuget.config /A %ArchiveDir% /Y
copy %ZDev%\omnisharp.json /A %ArchiveDir% /Y
copy %ZDev%\version /A %ArchiveDir% /Y
copy %ZDev%\z0.machine.sln /A %ArchiveDir% /Y



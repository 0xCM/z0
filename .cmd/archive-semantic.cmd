echo off

set DataSrc=%ZDb%\docs\asm.semantic\asm.semantic
echo DataSrc:%DataSrc%

set DataDst=k:\z0.archives\data\asm.semantic
echo DataDst:%DataDst%

set CopyLog=%ZDb%\etl\asm.semantic-archive.log
echo CopyLog:%CopyLog%

set CopyCmd=robocopy %DataSrc% %DataDst% /log:%CopyLog% /tee /TS /BYTES /V /MIR
echo CopyCmd:%CopyCmd%

echo on
call %CopyCmd%

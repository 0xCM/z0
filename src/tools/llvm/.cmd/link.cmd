echo off

echo LinkSrc:%LinkSrc%
echo LinkDst:%LinkDst%

set LinkCmd=mklink /D %LinkSrc% %LinkDst%
echo LinkCmd:%LinkCmd%

rmdir %LinkSrc%

echo on
call %LinkCmd%
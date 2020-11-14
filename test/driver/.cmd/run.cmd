echo off

call .cmd\config.cmd

set RunCmd=%ProjectTargetPath%
echo RunCmd:%RunCmd%

call %RunCmd%
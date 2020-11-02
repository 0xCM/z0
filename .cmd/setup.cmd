echo off

set SlnName=z0.sln
echo SlnName:%SlnName%

set SlnRoot=%ZDev%
echo SlnRoot:%SlnRoot%

set ScriptDir=%SlnRoot%\.cmd
echo ScriptDir:%ScriptDir%

set ProjectRoot=%SlnRoot%\src\%ProjectId%
echo ProjectRoot:%ProjectRoot%

set SlnPath=%SlnRoot%\%SlnName%
echo SlnPath:%SlnPath%

set ProjectPath=%ProjectRoot%\z0.%ProjectId%.csproj
echo ProjectPath:%ProjectPath%

set RunCmd=%ScriptDir%\run.cmd
echo RunCmd:%RunCmd%

set BuildCmd=%ScriptDir%\build.cmd
echo BuildCmd:%BuildCmd%

set AddCmd=%ScriptDir%\add.cmd
echo AddCmd:%AddCmd%
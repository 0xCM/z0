echo off

set SlnRoot=%ZDev%
echo SlnRoot:%SlnRoot%

set ProjectRoot=%SlnRoot%\src\%ProjectId%
echo ProjectRoot:%ProjectRoot%

set ScriptDir=%ProjectRoot%\.cmd
echo ScriptDir:%ScriptDir%

set SlnName=z0.sln
echo SlnName:%SlnName%

set SlnPath=%SlnRoot%\%SlnName%
echo SlnPath:%SlnPath%

set ProjectPath=%ProjectRoot%\z0.%ProjectId%.csproj
echo ProjectPath:%ProjectPath%

set RunCmd=%ScriptDir%\run.g.cmd
echo RunCmd:%RunCmd%

set BuildCmd=%ScriptDir%\build.g.cmd
echo BuildCmd:%BuildCmd%

set AddCmd=%ScriptDir%\add.g.cmd
echo AddCmd:%AddCmd%
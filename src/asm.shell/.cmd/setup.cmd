echo off

set ScriptColor=B
echo ScriptColor:%ScriptColor%
color %ScriptColor%

set ProjectId=asm.shell
echo ProjectId:%ProjectId%

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

set RunCmd=%ScriptDir%\run.cmd
echo RunCmd:%RunCmd%

set BuildCmd=%ScriptDir%\build.cmd
echo BuildCmd:%BuildCmd%
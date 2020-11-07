echo off

set ToolsetId=llvm

set ToolInfoRoot=%ZDev%\src\refs\content\tools
echo ToolInfoRoot:%ToolInfoRoot%

set ToolVarsCmd=%ToolInfoRoot%\vars.cmd
echo ToolVarsCmd:%ToolVarsCmd%

call %ToolVarsCmd%

set ToolCatalog=%ToolInfoRoot%\catalogs
echo ToolCatalog:%ToolCatalog%

set ToolHelp=%ToolInfoRoot%\help
echo ToolHelp:%ToolHelp%

set ToolSource=%LlvmProject%
echo ToolSource:%ToolSource%

set ToolExeListCmd=dir %ToolSource%\*.exe /s/b
echo ToolExeListCmd:%ToolSource%

echo on
call %ToolExeListCmd% > %ToolCatalog%\%ToolsetId%.list
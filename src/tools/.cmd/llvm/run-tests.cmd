echo off

set TestRoot=J:\lang\tools\llvm-project\build\unittests
set ScriptRoot=J:\dev\projects\z0\src\tools\.cmd\llvm
set TestLogRoot=J:\database\tools\llvm\test-logs
set RunCmd=%ScriptRoot%\run-test.cmd

set TestSubject=ExecutionEngine
call %RunCmd%

set TestSubject=FileCheck
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=Linker
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=LineEditor
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=MI
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=AsmParser
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=Bitcode
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=BinaryFormat
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=Bitstream
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=CodeGen
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=IR
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=InterfaceStub
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=ObjectYAML
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=Option
echo RunCmd:%RunCmd%
call %RunCmd%

set TestSubject=TableGen
echo RunCmd:%RunCmd%
call %RunCmd%

REM JitDisasm Script
if defined RunningJitDisasm (
  echo %CORE_ROOT%\corerun %CORE_ROOT%\jit-dasm.dll --crossgen %CORE_ROOT%/crossgen.exe --platform %CORE_ROOT%;%cd% --output ..\..\..\..\dasm\JIT\Methodical\ELEMENT_TYPE_IU\_il_dbgptr _il_dbgptr.exe
  %CORE_ROOT%\corerun %CORE_ROOT%\jit-dasm.dll --crossgen %CORE_ROOT%/crossgen.exe --platform %CORE_ROOT%;%cd% --output ..\..\..\..\dasm\JIT\Methodical\ELEMENT_TYPE_IU\_il_dbgptr _il_dbgptr.exe
  IF NOT "!ERRORLEVEL!"=="0" (
    ECHO EXECUTION OF JIT-DASM - FAILED !ERRORLEVEL!
    Exit /b 1
  )
  Exit /b 0
)
    

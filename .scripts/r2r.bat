echo off
REM Usage:
REM   ReadyToRun.SuperIlc [options] [command]

REM Options:
REM   --version    Display version information

REM Commands:
REM   compile-directory       Compile all assemblies in directory
REM   compile-subtree         Build each directory in a given subtree containing any managed assemblies as a separate app
REM   compile-framework       Compile managed framework assemblies in Core_Root
REM   compile-nuget           Restore a list of Nuget packages into an empty console app, publish, and optimize with Crossgen / CPAOT
REM   compile-crossgen-rsp    Use existing Crossgen .rsp file(s) to build assemblies, optionally rewriting base paths

REM Usage:
REM   ReadyToRun.SuperIlc compile-directory [options]

REM Options:
REM   -in, --input-directory <INPUT-DIRECTORY>                              Folder containing assemblies to optimize
REM   -out, --output-directory <OUTPUT-DIRECTORY>                           Folder to emit compiled assemblies
REM   -cr, --core-root-directory <CORE-ROOT-DIRECTORY>                      Location of the CoreCLR CORE_ROOT folder
REM   --crossgen <CROSSGEN>                                                 Compile the apps using Crossgen in the CORE_ROOT folder
REM   -cp, --crossgen-path <CROSSGEN-PATH>                                  Explicit Crossgen path (useful for cross-targeting)
REM   --nojit <NOJIT>                                                       Don't run tests in JITted mode
REM   --nocrossgen2 <NOCROSSGEN2>                                           Don't run tests in Crossgen2 mode
REM   --exe <EXE>                                                           Don't compile tests, just execute them
REM   --noexe <NOEXE>                                                       Compilation-only mode (don't execute the built apps)
REM   --noetw <NOETW>                                                       Don't capture jitted methods using ETW
REM   --nocleanup <NOCLEANUP>                                               Don't clean up compilation artifacts after test runs
REM   -dop, --degree-of-parallelism <DEGREE-OF-PARALLELISM>                 Override default compilation / execution DOP (default = logical processor count)
REM   --sequential <SEQUENTIAL>                                             Run tests sequentially
REM   --framework <FRAMEWORK>                                               Precompile and use native framework
REM   --use-framework <USE-FRAMEWORK>                                       Use native framework (don't precompile, assume previously compiled)
REM   --release <RELEASE>                                                   Build the tests in release mode
REM   --large-bubble <LARGE-BUBBLE>                                         Assume all input files as part of one version bubble
REM   -r, --reference-path <REFERENCE-PATH>                                 Folder containing assemblies to reference during compilation
REM   -ip, --issues-path <ISSUES-PATH>                                      Path to issues.targets
REM   -ct, --compilation-timeout-minutes <COMPILATION-TIMEOUT-MINUTES>      Compilation timeout (minutes)
REM   -et, --execution-timeout-minutes <EXECUTION-TIMEOUT-MINUTES>          Execution timeout (minutes)
REM   -r2r, --r2r-dump-path <R2R-DUMP-PATH>                                 Path to R2RDump.exe/dll
REM   --measure-perf <MEASURE-PERF>                                         Print out compilation time
REM   -input-file, --input-file-search-string <INPUT-FILE-SEARCH-STRING>    Search string for input files in the input directory

set CoreRel=J:\lang\net\runtime\artifacts\bin\coreclr\Windows_NT.x64.Release
set Tool=ReadyToRun.SuperIlc.exe
set ToolPath=%CoreRel%\ReadyToRun.SuperIlc\%Tool%

set SrcDir=%ZBin%
set Cmd=%ToolPath% compile-directory %SrcDir%

echo on
call %Cmd%


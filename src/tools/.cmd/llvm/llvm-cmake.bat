set SubProjects=clang;libc;libclc;clang-tools-extra;libcxx;libcxxabi;libunwind;lldb;compiler-rt;lld;polly;debuginfo-tests;mlir;pstl;parallel-libs;openmp
set Generator="Visual Studio 16 2019"
set SrcDir=j:\lang\tools\llvm-project\llvm
set BuildDir=j:\lang\tools\llvm-project\build
cmake -G %Generator% -Thost=x64 -S %SrcDir% -B %BuildDir% -DLLVM_ENABLE_PROJECTS=%SubProjects%
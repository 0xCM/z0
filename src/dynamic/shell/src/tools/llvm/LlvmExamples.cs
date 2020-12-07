//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    public readonly struct LlvmExamples
    {
        public static CmdLine TblGenIntrinsicEnums
            => "llvm-tblgen -gen-intrinsic-enums -intrinsic-prefix=x86 -I J:/lang/tools/llvm-project/llvm/include/llvm/IR -IJ:/lang/tools/llvm-project/build/include -IJ:/lang/tools/llvm-project/llvm/include --long-string-literals=0 J:/lang/tools/llvm-project/llvm/include/llvm/IR/Intrinsics.td -o J:/lang/tools/llvm-project/build/include/llvm/IR/IntrinsicsX86.h";

    }
}
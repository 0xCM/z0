//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct LlvmToolNames
    {
        public const string clang_query = "clang-query";

        public const string llvm_nm = "llvm-nm";

        public const string llvm_mc = "llvm-mc";

        public const string llc = "llc";

        public const string llvm_objdump ="llvm-objdump";
    }
}
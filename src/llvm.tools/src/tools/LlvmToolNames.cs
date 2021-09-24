//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [LiteralProvider]
    public readonly struct LlvmToolNames
    {
        public const string clang = "clang";

        public const string clang_cl = "clang-cl";

        public const string clang_query = "clang-query";

        public const string llvm_as = "llvm-as";

        public const string llvm_nm = "llvm-nm";

        public const string obj2yaml = "obj2yaml";

        public const string llvm_lli = "lli";

        public const string llvm_mc = "llvm-mc";

        public const string llvm_ml = "llvm-ml";

        public const string llvm_tblgen = "llvm-tblgen";

        public const string llc = "llc";

        public const string llvm_objdump ="llvm-objdump";

        public const string yaml_bench ="yaml-bench";

        public const string llvm_readobj ="llvm-readobj";
    }
}
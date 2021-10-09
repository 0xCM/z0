//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    [LiteralProvider]
    public readonly struct LlvmDatasetNames
    {
        public const string TblgenRecords = "llvm.tblgen.records";

        public const string TblgenLists = "llvm.tblgen.lists";

        public const string X86Instructions = "x86.instructions";

        public const string X86Classes = "x86.classes";

        public const string LlvmIntrinsics = "llvm.intrinsics";
    }
}
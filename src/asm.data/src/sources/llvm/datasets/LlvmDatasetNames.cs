//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    [LiteralProvider]
    public readonly struct LlvmDatasetNames
    {
        public const string LlvmDatasetScope = "llvm.tblgen.records";

        public const string InstrinsicsSummary = "llvm.intrinsics.td-summary";

        public const string InstrinsicsDetails = "llvm.intrinsics.td-details";

        public const string X86Summary = "X86.X86.td-summary";

        public const string X86Details = "X86.X86.td-details";

        public const string X86Regs = "X86.register-info-debug";

        public const string ValueTypesSummary = "llvm.valuetypes.td-summary";

        public const string ValueTypesDetails = "llvm.valuetypes.td-details";
    }
}
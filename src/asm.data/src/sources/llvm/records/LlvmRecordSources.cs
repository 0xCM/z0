//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    public struct LlvmRecordSources
    {
        public Index<TextLine> IntrinsicsSummary;

        public Index<TextLine> IntrinsicsDetails;

        public Index<TextLine> InstructionDetails;

        public Index<TextLine> InstructionSummary;

        public Index<TextLine> Regs;

        public Index<TextLine> ValueTypesSummary;

        public Index<TextLine> ValueTypesDetails;

        public uint TotalLineCount()
            => IntrinsicsSummary.Count + IntrinsicsDetails.Count +
            InstructionDetails.Count + InstructionSummary.Count +
            Regs.Count + ValueTypesSummary.Count + ValueTypesDetails.Count;

    }
}
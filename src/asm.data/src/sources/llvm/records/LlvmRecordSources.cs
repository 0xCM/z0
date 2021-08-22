//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [StructLayout(LayoutKind.Sequential)]
    public struct LlvmRecordSources
    {
        public Index<TextLine> IntrinsicsSummary;

        public Index<TextLine> IntrinsicsDetails;

        public Index<TextLine> InstructionDetails;

        public Index<TextLine> InstructionSummary;

        public Index<TextLine> ValueTypesSummary;

        public Index<TextLine> ValueTypesDetails;

        [MethodImpl(Inline)]
        public uint TotalLineCount()
            => IntrinsicsSummary.Count +
            IntrinsicsDetails.Count +
            InstructionDetails.Count +
            InstructionSummary.Count +
            ValueTypesSummary.Count +
            ValueTypesDetails.Count;

        public bool IsEmtpty
        {
            [MethodImpl(Inline)]
            get => TotalLineCount() == 0;
        }
    }
}
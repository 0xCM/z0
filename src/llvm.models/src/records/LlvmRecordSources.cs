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
        public Index<TextLine> Intrinsics;

        public Index<TextLine> Instructions;

        public Index<TextLine> ValueTypes;

        [MethodImpl(Inline)]
        public uint TotalLineCount()
            => Intrinsics.Count +
            Instructions.Count +
            ValueTypes.Count;

        public bool IsEmtpty
        {
            [MethodImpl(Inline)]
            get => TotalLineCount() == 0;
        }
    }
}
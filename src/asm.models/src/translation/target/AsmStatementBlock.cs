//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsmStatementBlock
    {
        readonly TableSpan<AsmStatementCode> Data;

        [MethodImpl(Inline)]
        public AsmStatementBlock(AsmStatementCode[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementBlock(AsmStatementCode[] src)
            => new AsmStatementBlock(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementCode[](AsmStatementBlock src)
            => src.Data;

        public ReadOnlySpan<AsmStatementCode> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<AsmStatementCode> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref AsmStatementCode First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }
    }
}
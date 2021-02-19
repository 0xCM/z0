//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public readonly struct StatementBlock
        {
            readonly Index<SourceCode> Data;

            [MethodImpl(Inline)]
            public StatementBlock(SourceCode[] src)
                => Data = src;

            public uint Count
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            [MethodImpl(Inline)]
            public static implicit operator StatementBlock(SourceCode[] src)
                => new StatementBlock(src);

            [MethodImpl(Inline)]
            public static implicit operator SourceCode[](StatementBlock src)
                => src.Data;

            public ReadOnlySpan<SourceCode> View
            {
                [MethodImpl(Inline)]
                get => Data.View;
            }

            public Span<SourceCode> Edit
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
            }

            public ref SourceCode First
            {
                [MethodImpl(Inline)]
                get => ref Data.First;
            }
        }
    }
}
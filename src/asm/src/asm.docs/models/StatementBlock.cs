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

    partial struct AsmDocParts
    {
        public readonly struct StatementBlock
        {
            readonly Index<StatementSource> Data;

            [MethodImpl(Inline)]
            public StatementBlock(StatementSource[] src)
                => Data = src;

            public uint Count
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }

            [MethodImpl(Inline)]
            public static implicit operator StatementBlock(StatementSource[] src)
                => new StatementBlock(src);

            [MethodImpl(Inline)]
            public static implicit operator StatementSource[](StatementBlock src)
                => src.Data;

            public ReadOnlySpan<StatementSource> View
            {
                [MethodImpl(Inline)]
                get => Data.View;
            }

            public Span<StatementSource> Edit
            {
                [MethodImpl(Inline)]
                get => Data.Edit;
            }

            public ref StatementSource First
            {
                [MethodImpl(Inline)]
                get => ref Data.First;
            }
        }
    }
}
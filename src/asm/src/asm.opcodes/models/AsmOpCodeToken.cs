//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct AsmOpCodeToken
    {
        readonly SegRef<char> Source;

        public byte Index {get;}

        public AsmOpCodeTokenKind Id {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeToken(byte index, AsmOpCodeTokenKind id, SegRef<char> src)
        {
            Index = index;
            Source = src;
            Id = id;
        }

        public ReadOnlySpan<char> Symbols
        {
            [MethodImpl(Inline)]
            get => cover<char>(Source.BaseAddress, Source.CellCount);
        }
    }
}
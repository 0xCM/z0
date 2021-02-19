//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Cells;
    using static memory;

    partial struct AsmRegBanks
    {
        public readonly ref struct V256Bank
        {
            readonly Span<Cell256> Data;

            [MethodImpl(Inline)]
            internal V256Bank(Cell256[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public ref Cell128 r128(RegIndex i)
                => ref lo128(ref r256(i));

            [MethodImpl(Inline)]
            public ref Cell256 r256(RegIndex i)
                => ref seek(Data,(byte)i);
        }
    }
}
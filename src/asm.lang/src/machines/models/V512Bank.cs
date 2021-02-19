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
        public readonly ref struct V512Bank
        {
            readonly Span<Cell512> Data;

            [MethodImpl(Inline)]
            internal V512Bank(Cell512[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public ref Cell128 r128(RegIndex i)
                => ref lo128(ref r512(i));

            [MethodImpl(Inline)]
            public ref Cell256 r256(RegIndex i)
                => ref lo256(ref r512(i));

            [MethodImpl(Inline)]
            public ref Cell512 r512(RegIndex i)
                => ref seek(Data, (byte)i);
        }
    }
}
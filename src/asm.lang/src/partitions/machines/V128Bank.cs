//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct AsmRegBanks
    {
        public readonly ref struct V128Bank
        {
            readonly Span<Cell128> Data;

            [MethodImpl(Inline)]
            internal V128Bank(Cell128[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public ref Cell128 r128(RegIndex i)
                => ref seek(Data, (byte)i);
        }
    }
}
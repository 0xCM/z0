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
    using static Cells;

    partial struct AsmRegBanks
    {
        public readonly ref struct Gp64Bank
        {
            readonly Span<Cell64> Data;

            [MethodImpl(Inline)]
            internal Gp64Bank(Cell64[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public ref Cell8 r8(RegIndex i)
                => ref lo8(r64(i));

            [MethodImpl(Inline)]
            public ref Cell16 r16(RegIndex i)
                => ref lo16(r64(i));

            [MethodImpl(Inline)]
            public ref Cell32 r32(RegIndex i)
                => ref lo32(r64(i));

            [MethodImpl(Inline)]
            public ref Cell64 r64(RegIndex i)
                => ref seek(Data,(byte)i);
        }
    }
}
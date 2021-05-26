//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Cells;
    using static core;

    [ApiHost]
    public readonly struct AsmRegBanks
    {
        [Op]
        public static V512Bank create(W512 w, byte count)
            => new V512Bank(new Cell512[count]);

        [Op]
        public static V256Bank create(W256 w, byte count)
            => new V256Bank(new Cell256[count]);

        [Op]
        public static V128Bank create(W128 w, byte count)
            => new V128Bank(new Cell128[count]);

        [Op]
        public static Gp64Bank create(W64 w, byte count)
            => new Gp64Bank(new Cell64[count]);


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

        public readonly ref struct V256Bank
        {
            readonly Span<Cell256> Data;

            [MethodImpl(Inline)]
            internal V256Bank(Cell256[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public ref Cell128 r128(RegIndex i)
                => ref lo128(r256(i));

            [MethodImpl(Inline)]
            public ref Cell256 r256(RegIndex i)
                => ref seek(Data,(byte)i);
        }

        public readonly ref struct V512Bank
        {
            readonly Span<Cell512> Data;

            [MethodImpl(Inline)]
            internal V512Bank(Cell512[] src)
                => Data = src;

            [MethodImpl(Inline)]
            public ref Cell128 r128(RegIndex i)
                => ref lo128(r512(i));

            [MethodImpl(Inline)]
            public ref Cell256 r256(RegIndex i)
                => ref lo256(r512(i));

            [MethodImpl(Inline)]
            public ref Cell512 r512(RegIndex i)
                => ref seek(Data, (byte)i);
        }
    }
}
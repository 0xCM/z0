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
    public readonly struct RegBanks
    {
        [Op]
        public static ZmmBank create(W512 w, byte count)
            => new ZmmBank(new Cell512[count]);

        [Op]
        public static YmmBank create(W256 w, byte count)
            => new YmmBank(new Cell256[count]);

        [Op]
        public static XmmBank create(W128 w, byte count)
            => new XmmBank(new Cell128[count]);

        [Op]
        public static Gp64Bank create(W64 w, byte count)
            => new Gp64Bank(new Cell64[count]);

        [MethodImpl(Inline), Op]
        public static Gp64Bank create(Span<Cell64> src)
            => new Gp64Bank(src);

        [MethodImpl(Inline), Op]
        public static XmmBank create(Span<Cell128> src)
            => new XmmBank(src);

        [MethodImpl(Inline), Op]
        public static YmmBank create(Span<Cell256> src)
            => new YmmBank(src);

        [MethodImpl(Inline), Op]
        public static ZmmBank create(Span<Cell512> src)
            => new ZmmBank(src);

        public readonly ref struct Gp64Bank
        {
            readonly Span<Cell64> Data;

            [MethodImpl(Inline)]
            internal Gp64Bank(Span<Cell64> src)
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

            internal Span<Cell64> Cells
            {
                [MethodImpl(Inline)]
                get => Data;
            }
        }

        public readonly ref struct XmmBank
        {
            readonly Span<Cell128> Data;

            [MethodImpl(Inline)]
            internal XmmBank(Span<Cell128> src)
                => Data = src;

            [MethodImpl(Inline)]
            public ref Cell128 r128(RegIndex i)
                => ref seek(Data, (byte)i);

            internal Span<Cell128> Cells
            {
                [MethodImpl(Inline)]
                get => Data;
            }

        }

        public readonly ref struct YmmBank
        {
            readonly Span<Cell256> Data;

            [MethodImpl(Inline)]
            internal YmmBank(Span<Cell256> src)
                => Data = src;

            [MethodImpl(Inline)]
            public ref Cell128 r128(RegIndex i)
                => ref lo128(r256(i));

            [MethodImpl(Inline)]
            public ref Cell256 r256(RegIndex i)
                => ref seek(Data,(byte)i);

            internal Span<Cell256> Cells
            {
                [MethodImpl(Inline)]
                get => Data;
            }

        }

        public readonly ref struct ZmmBank
        {
            readonly Span<Cell512> Data;

            [MethodImpl(Inline)]
            internal ZmmBank(Span<Cell512> src)
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

            internal Span<Cell512> Cells
            {
                [MethodImpl(Inline)]
                get => Data;
            }
        }
    }
}
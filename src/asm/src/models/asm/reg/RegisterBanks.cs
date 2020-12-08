//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Cells;
    using static z;

    public readonly struct RegisterBanks
    {
        public static RV512 alloc(W512 w, byte count)
            => new RV512(new Cell512[count]);

        public static RV256 alloc(W256 w, byte count)
            => new RV256(new Cell256[count]);

        public static RV128 alloc(W128 w, byte count)
            => new RV128(new Cell128[count]);

        public static Gp64 alloc(W64 w, byte count)
            => new Gp64(new Cell64[count]);

        public readonly struct RV512
        {
            readonly Cell512[] Data;

            internal RV512(Cell512[] src)
                => Data = src;

            public ref Cell512 First
            {
                [MethodImpl(Inline)]
                get => ref memory.first(Data);
            }

            [MethodImpl(Inline)]
            public ref Cell512 r512(byte i)
                => ref memory.seek(First, i);

            [MethodImpl(Inline)]
            public ref Cell256 r256(byte i)
                => ref c256(ref r512(i));

            [MethodImpl(Inline)]
            public ref Cell128 r128(byte i)
                => ref c128(ref r512(i));
        }

        public readonly struct RV256
        {
            internal RV256(Cell256[] src)
                => Data = src;

            readonly Cell256[] Data;

            public ref Cell256 First
            {
                [MethodImpl(Inline)]
                get => ref memory.first(Data);
            }

            [MethodImpl(Inline)]
            public ref Cell256 r256(byte i)
                => ref memory.seek(First, i);

            [MethodImpl(Inline)]
            public ref Cell128 r128(byte i)
                => ref c128(ref r256(i));
        }

        public readonly struct RV128
        {
            internal RV128(Cell128[] src)
                => Data = src;

            readonly Cell128[] Data;

            public ref Cell128 First
            {
                [MethodImpl(Inline)]
                get => ref memory.first(Data);
            }

            [MethodImpl(Inline)]
            public ref Cell128 r128(byte i)
                => ref memory.seek(First, i);
        }

        public readonly struct Gp64
        {
            internal Gp64(Cell64[] src)
                => Data = src;

            readonly Cell64[] Data;

            public ref Cell64 First
            {
                [MethodImpl(Inline)]
                get => ref memory.first(Data);
            }

            [MethodImpl(Inline)]
            public ref Cell64 r64(byte i)
                => ref memory.seek(First, i);

            [MethodImpl(Inline)]
            public ref Cell32 r32(byte i)
                => ref c32(ref r64(i));

            [MethodImpl(Inline)]
            public ref Cell16 r16(byte i)
                => ref c16(ref r64(i));

            [MethodImpl(Inline)]
            public ref Cell8 r8(byte i)
                => ref c8(ref r64(i));
        }
    }
}
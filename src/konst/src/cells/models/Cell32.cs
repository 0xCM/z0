//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Cell32 : ICellHost<Cell32,W32,uint>
    {
        internal readonly uint Data;

        [MethodImpl(Inline)]
        public static Cell32 init(uint src)
            => new Cell32(src);

        [MethodImpl(Inline)]
        public static Cell32 init(byte src)
            => new Cell32(src);

        [MethodImpl(Inline)]
        public static Cell32 init(ushort src)
            => new Cell32(src);

        [MethodImpl(Inline)]
        public static Cell32 init(Cell8 src)
            => new Cell32(src.Data);

        [MethodImpl(Inline)]
        public static Cell32 init(Cell16 src)
            => new Cell32(src.Data);

        [MethodImpl(Inline)]
        public static Cell32 init(int src)
            => new Cell32((uint)src);

        public uint Content
        {
            [MethodImpl(Inline)] get => Data;
        }

        public Cell16 Lo
        {
            [MethodImpl(Inline)]
            get => (ushort)Data;
        }

        public Cell16 Hi
        {
            [MethodImpl(Inline)]
            get => (ushort)(Data >> 16);
        }

        public Cell32 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        Cell32(uint x0)
            => Data = x0;

        [MethodImpl(Inline)]
        public static implicit operator Cell32(uint x0)
            => init(x0);

        [MethodImpl(Inline)]
        public static implicit operator Cell32(int x0)
            => init(x0);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Cell32 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator byte(Cell32 x)
            => (byte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator short(Cell32 x)
            => (short)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Cell32 x)
            => (ushort)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator uint(Cell32 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(Cell32 x)
            => (int)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator long(Cell32 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Cell32 x)
            => (ulong)x.Data;


        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
              => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(Cell32 src)
            => Data == src.Data;

        [MethodImpl(Inline)]
        public bool Equals(uint src)
            => Data == src;

        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is Cell32 x && Equals(x);

        public static Cell32 Empty => default;
    }
}
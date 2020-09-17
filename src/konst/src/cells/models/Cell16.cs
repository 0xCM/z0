//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Cell16 : ICellHost<Cell16,W16,ushort>
    {
        internal readonly ushort Data;

        public ushort Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Cell8 Lo
        {
            [MethodImpl(Inline)]
            get => (byte)Data;
        }

        public Cell8 Hi
        {
            [MethodImpl(Inline)]
            get => (byte)(Data >> 8);
        }

        public Cell16 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public static Cell16 From(byte src)
            => new Cell16(src);

        [MethodImpl(Inline)]
        public static Cell16 From(ushort src)
            => new Cell16(src);


        [MethodImpl(Inline)]
        public static Cell16 From(Cell8 src)
            => new Cell16(src.Data);

        [MethodImpl(Inline)]
        public static Cell16 From(short src)
            => new Cell16((ushort)src);

        [MethodImpl(Inline)]
        public static Cell16 From(int src)
            => new Cell16((ushort)(short)src);

        [MethodImpl(Inline)]
        public static Cell16 From(uint src)
            => new Cell16((ushort)src);

        [MethodImpl(Inline)]
        Cell16(ushort x)
            => Data = x;

        [MethodImpl(Inline)]
        public static implicit operator ushort(Cell16 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static implicit operator uint(Cell16 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static implicit operator ulong(Cell16 x)
            => x.Data;

        [MethodImpl(Inline)]
        public static implicit operator Cell16(ushort x)
            => From(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell16(Cell8 x)
            => From(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Cell32(Cell16 x)
            => Cell32.init(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Cell64(Cell16 x)
            => Cell64.From(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Cell16(byte x)
            => From((ushort)x);

        [MethodImpl(Inline)]
        public static implicit operator Cell16(short x)
            => From(x);

        [MethodImpl(Inline)]
        public static explicit operator Cell16(int x)
            => From(x);

        [MethodImpl(Inline)]
        public static explicit operator Cell16(uint x)
            => From(x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Cell16 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator byte(Cell16 x)
            => (byte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator short(Cell16 x)
            => (short)x.Data;


        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
                => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(Cell16 src)
            => Data == src.Data;

        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(ushort src)
            => Data == src;

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is Cell16 x && Equals(x);


        public static Cell16 Empty
            => default(Cell16);

   }
}
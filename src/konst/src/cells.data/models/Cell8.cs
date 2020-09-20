//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Cell8 : IDataCell<Cell8,W8,byte>
    {
        internal readonly byte Data;

        public byte Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public static Cell8 From(byte src)
            => new Cell8(src);

        [MethodImpl(Inline)]
        public static Cell8 From(sbyte src)
            => new Cell8((byte)src);

        [MethodImpl(Inline)]
        public static Cell8 From(int src)
            => new Cell8((byte)(sbyte)src);

        [MethodImpl(Inline)]
        public static Cell8 From(uint src)
            => new Cell8((byte)src);

        public Cell8 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        Cell8(byte x0)
            => Data = x0;

        [MethodImpl(Inline)]
        public static implicit operator byte(Cell8 src)
            => (byte)src.Data;

        [MethodImpl(Inline)]
        public static implicit operator Cell8(byte src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell8(sbyte x0)
            => From(x0);

        [MethodImpl(Inline)]
        public static implicit operator Cell16(Cell8 x)
            => Cell16.From(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Cell32(Cell8 x)
            => Cell32.init(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Cell64(Cell8 x)
            => Cell64.From(x.Data);

        [MethodImpl(Inline)]
        public static explicit operator Cell8(int x)
            => new Cell8((byte)(sbyte)x);

        [MethodImpl(Inline)]
        public static explicit operator Cell8(uint x)
            => new Cell8((byte)x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Cell8 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(Cell8 x)
            => (int)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator uint(Cell8 x)
            => (uint)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator long(Cell8 x)
            => (long)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Cell8 x)
            => (ulong)x.Data;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
              => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(Cell8 src)
            => Data == src.Data;

        [MethodImpl(Inline)]
        public bool Equals(byte src)
            => Data == src;

        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is Cell8 x && Equals(x);

        public static Cell8 Empty => default;
    }
}
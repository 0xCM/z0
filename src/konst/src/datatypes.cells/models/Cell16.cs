//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Cell16 : IDataCell<Cell16,W16,ushort>
    {
        internal readonly ushort Data;

        public CellKind Kind => CellKind.Cell16;

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
        public static Cell16 init(byte src)
            => new Cell16(src);

        [MethodImpl(Inline)]
        public static Cell16 init(ushort src)
            => new Cell16(src);

        [MethodImpl(Inline)]
        public static Cell16 init(Cell8 src)
            => new Cell16(src.Data);

        [MethodImpl(Inline)]
        public static Cell16 init(short src)
            => new Cell16((ushort)src);

        [MethodImpl(Inline)]
        public static Cell16 init(int src)
            => new Cell16((ushort)(short)src);

        [MethodImpl(Inline)]
        public static Cell16 init(uint src)
            => new Cell16((ushort)src);

        [MethodImpl(Inline)]
        internal Cell16(ushort x)
            => Data = x;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
                => NumericCast.force<T>(Data);

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
            => init(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell16(Cell8 x)
            => init(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Cell32(Cell16 x)
            => Cell32.init(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Cell64(Cell16 x)
            => Cell64.init(x.Data);

        [MethodImpl(Inline)]
        public static implicit operator Cell16(byte x)
            => init((ushort)x);

        [MethodImpl(Inline)]
        public static implicit operator Cell16(short x)
            => init(x);

        [MethodImpl(Inline)]
        public static explicit operator Cell16(int x)
            => init(x);

        [MethodImpl(Inline)]
        public static explicit operator Cell16(uint x)
            => init(x);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Cell16 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator byte(Cell16 x)
            => (byte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator short(Cell16 x)
            => (short)x.Data;

        public static Cell16 Empty
            => default(Cell16);
   }
}
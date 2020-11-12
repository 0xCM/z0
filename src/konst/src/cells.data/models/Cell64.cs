//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Cell64 : IDataCell<Cell64,W64,ulong>
    {
        internal readonly ulong Data;

        public CellKind Kind => CellKind.Cell64;

        public ulong Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Cell32 Lo
        {
            [MethodImpl(Inline)]
            get => (uint)Data;
        }

        public Cell32 Hi
        {
            [MethodImpl(Inline)]
            get => (uint)(Data >> 32);
        }

        public Cell64 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public static Cell64 init(int src)
            => new Cell64((ulong)(long)src);

        [MethodImpl(Inline)]
        public static Cell64 init(byte src)
            => new Cell64(src);

        [MethodImpl(Inline)]
        public static Cell64 init(ushort src)
            => new Cell64(src);

        [MethodImpl(Inline)]
        public static Cell64 init(uint src)
            => new Cell64(src);

        [MethodImpl(Inline)]
        public static Cell64 init(ulong src)
            => new Cell64(src);

        [MethodImpl(Inline)]
        public static Cell64 init(Cell8 src)
            => new Cell64(src.Data);

        [MethodImpl(Inline)]
        public static Cell64 init(Cell16 src)
            => new Cell64(src.Data);

        [MethodImpl(Inline)]
        public static Cell64 init(Cell32 src)
            => new Cell64(src.Data);

        [MethodImpl(Inline)]
        public static Cell64 init(long src)
            => new Cell64((ulong)src);

        [MethodImpl(Inline)]
        Cell64(ulong x0)
            => Data = x0;

        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
                => Cast.to<T>(Data);

        [MethodImpl(Inline)]
        public bool Equals(ulong src)
            => Data == src;

        [MethodImpl(Inline)]
        public bool Equals(Cell64 src)
            => Data == src.Data;

        public string Format()
            => Data.ToString();

        public override string ToString()
            => Format();

         public override int GetHashCode()
            => Data.GetHashCode();

        public override bool Equals(object src)
            => src is Cell64 x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell64(int x0)
            => init(x0);

        [MethodImpl(Inline)]
        public static implicit operator Cell64(long x0)
            => init(x0);

        [MethodImpl(Inline)]
        public static implicit operator Cell64(ulong x0)
            => init(x0);

        [MethodImpl(Inline)]
        public static implicit operator Cell64(Cell32 x0)
            => init(x0);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Cell64 x)
            => (sbyte)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator short(Cell64 x)
            => (short)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Cell64 x)
            => (ushort)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator uint(Cell64 x)
            => (uint)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator int(Cell64 x)
            => (int)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator long(Cell64 x)
            => (long)x.Data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Cell64 x)
            => x.Data;

        public static Cell64 Empty => default;

   }
}
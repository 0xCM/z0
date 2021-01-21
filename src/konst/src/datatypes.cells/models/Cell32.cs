//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Cells;

    public readonly struct Cell32 : IDataCell<Cell32,W32,uint>
    {
        public uint Content {get;}

        [MethodImpl(Inline)]
        public Cell32(uint x0)
            => Content = x0;

        [MethodImpl(Inline)]
        public Cell32(int x0)
            => Content = (uint)x0;

        public CellKind Kind
            => CellKind.Cell32;

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => api.bytes(this);
        }

        public Cell16 Lo
        {
            [MethodImpl(Inline)]
            get => (ushort)Content;
        }

        public Cell16 Hi
        {
            [MethodImpl(Inline)]
            get => (ushort)(Content >> 16);
        }

        public Cell32 Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        [MethodImpl(Inline)]
        public T As<T>()
            where T : struct
              => NumericCast.force<T>(Content);

        [MethodImpl(Inline)]
        public bool Equals(Cell32 src)
            => Content == src.Content;

        [MethodImpl(Inline)]
        public bool Equals(uint src)
            => Content == src;

        public string Format()
            => Content.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Content.GetHashCode();

        public override bool Equals(object src)
            => src is Cell32 x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator Cell32(uint x0)
            => new Cell32(x0);

        [MethodImpl(Inline)]
        public static implicit operator Cell32(int x0)
            => new Cell32(x0);

        [MethodImpl(Inline)]
        public static explicit operator sbyte(Cell32 x)
            => (sbyte)x.Content;

        [MethodImpl(Inline)]
        public static explicit operator byte(Cell32 x)
            => (byte)x.Content;

        [MethodImpl(Inline)]
        public static explicit operator short(Cell32 x)
            => (short)x.Content;

        [MethodImpl(Inline)]
        public static explicit operator ushort(Cell32 x)
            => (ushort)x.Content;

        [MethodImpl(Inline)]
        public static explicit operator uint(Cell32 x)
            => x.Content;

        [MethodImpl(Inline)]
        public static explicit operator int(Cell32 x)
            => (int)x.Content;

        [MethodImpl(Inline)]
        public static explicit operator long(Cell32 x)
            => x.Content;

        [MethodImpl(Inline)]
        public static explicit operator ulong(Cell32 x)
            => (ulong)x.Content;

        public static Cell32 Empty => default;
    }
}
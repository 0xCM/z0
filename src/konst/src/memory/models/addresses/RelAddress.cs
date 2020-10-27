//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using NW = NumericWidth;

    public readonly struct RelativeAddress : INullary<RelativeAddress>, ITextual, INullity
    {
        readonly uint Offset;

        readonly NumericWidth Size;

        public static RelativeAddress Empty
            => new RelativeAddress(0, NW.None);

        public bool IsEmpty
        {
             [MethodImpl(Inline)]
             get => Offset == 0;
        }

        public bool IsNonEmpty
        {
             [MethodImpl(Inline)]
             get => Offset != 0;
        }

        public RelativeAddress Zero
        {
             [MethodImpl(Inline)]
             get => Empty;
        }

        [MethodImpl(Inline)]
        public static RelativeAddress From(byte offset)
            => new RelativeAddress(offset, NW.W8);

        [MethodImpl(Inline)]
        public static RelativeAddress From(ushort offset)
            => new RelativeAddress(offset, NW.W16);

        [MethodImpl(Inline)]
        public static RelativeAddress From(uint offset)
            => new RelativeAddress(offset, NW.W32);

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, byte y)
            => From((byte)(x.Offset + y));

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, ushort y)
            => From((ushort)(x.Offset + y));

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, uint y)
            => From(x.Offset + y);

        [MethodImpl(Inline)]
        public static bool operator==(RelativeAddress x, RelativeAddress y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelativeAddress x, RelativeAddress y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        RelativeAddress(uint offset, NumericWidth size)
        {
            Offset = (uint)offset;
            Size = size;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Offset.FormatSmallHex(true);

        public bool Equals(RelativeAddress src)
            => Offset == src.Offset;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Offset.GetHashCode();

        public override bool Equals(object src)
            => src is RelativeAddress l && Equals(l);
    }
}
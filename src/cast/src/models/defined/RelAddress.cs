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

    public readonly struct RelAddress : INullary<RelAddress>, ITextual, INullaryKnown
    {
        readonly uint Offset;

        readonly NumericWidth Size;

        public static RelAddress Empty => new RelAddress(0, NW.None);

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

        public RelAddress Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static RelAddress From(byte offset)
            => new RelAddress(offset, NW.W8);

        [MethodImpl(Inline)]
        public static RelAddress From(ushort offset)
            => new RelAddress(offset, NW.W16);

        [MethodImpl(Inline)]
        public static RelAddress From(uint offset)
            => new RelAddress(offset, NW.W32);

        [MethodImpl(Inline)]
        public static RelAddress operator+(RelAddress x, byte y)
            => From((byte)(x.Offset + y));

        [MethodImpl(Inline)]
        public static RelAddress operator+(RelAddress x, ushort y)
            => From((ushort)(x.Offset + y));

        [MethodImpl(Inline)]
        public static RelAddress operator+(RelAddress x, uint y)
            => From(x.Offset + y);

        [MethodImpl(Inline)]
        public static bool operator==(RelAddress x, RelAddress y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelAddress x, RelAddress y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        RelAddress(uint offset, NumericWidth size)
        {
            Offset = (uint)offset;
            Size = size;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Offset.FormatSmallHex(true);
        
        public bool Equals(RelAddress src)        
            => Offset == src.Offset;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Offset.GetHashCode();
        
        public override bool Equals(object src)
            => src is RelAddress l && Equals(l);
    }
}
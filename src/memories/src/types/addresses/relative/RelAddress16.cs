//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct RelAddress16 : INullary<RelAddress16>, ITextual, INullaryKnown
    {
        readonly ushort Offset;

        public static RelAddress16 Empty => new RelAddress16(0);

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

        public RelAddress16 Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static RelAddress16 From(ushort offset)
            => new RelAddress16(offset);

        [MethodImpl(Inline)]
        public static RelAddress16 operator+(RelAddress16 x, ushort y)
            => From((ushort)(x.Offset + y));

        [MethodImpl(Inline)]
        public static bool operator==(RelAddress16 x, RelAddress16 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelAddress16 x, RelAddress16 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        RelAddress16(ushort offset)
        {
            Offset = offset;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Offset.FormatSmallHex(true);
        
        public bool Equals(RelAddress16 src)        
            => Offset == src.Offset;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Offset.GetHashCode();
        
        public override bool Equals(object src)
            => src is RelAddress16 l && Equals(l);
    }
}
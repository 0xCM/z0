//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct RelAddress8 : INullary<RelAddress8>, ITextual, INullaryKnown
    {
        readonly byte Offset;

        public static RelAddress8 Empty => new RelAddress8(0);

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

        public RelAddress8 Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static RelAddress8 From(byte offset)
            => new RelAddress8(offset);

        [MethodImpl(Inline)]
        public static RelAddress8 operator+(RelAddress8 x, byte y)
            => From((byte)(x.Offset + y));

        [MethodImpl(Inline)]
        public static bool operator==(RelAddress8 x, RelAddress8 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelAddress8 x, RelAddress8 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        RelAddress8(byte offset)
        {
            Offset = offset;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Offset.FormatSmallHex(true);
        
        public bool Equals(RelAddress8 src)        
            => Offset == src.Offset;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Offset.GetHashCode();
        
        public override bool Equals(object src)
            => src is RelAddress8 l && Equals(l);
    }
}
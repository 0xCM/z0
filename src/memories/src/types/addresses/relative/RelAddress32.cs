//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct RelAddress32 : INullary<RelAddress32>, ITextual, INullaryKnown
    {
        readonly uint Offset;

        public static RelAddress32 Empty => new RelAddress32(0);

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

        public RelAddress32 Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static RelAddress32 From(uint offset)
            => new RelAddress32(offset);

        [MethodImpl(Inline)]
        public static RelAddress32 operator+(RelAddress32 x, uint y)
            => From((uint)(x.Offset + y));

        [MethodImpl(Inline)]
        public static bool operator==(RelAddress32 x, RelAddress32 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelAddress32 x, RelAddress32 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        RelAddress32(uint offset)
        {
            Offset = offset;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Offset.FormatSmallHex(true);
        
        public bool Equals(RelAddress32 src)        
            => Offset == src.Offset;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Offset.GetHashCode();
        
        public override bool Equals(object src)
            => src is RelAddress32 l && Equals(l);
    }
}
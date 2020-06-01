//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Address16 : IAddress<Address16,W16,ushort>
    {
        public ushort Location {get;}

        public static Address16 Empty => new Address16(0);

        public bool IsEmpty 
        {
             [MethodImpl(Inline)] 
             get => Location == 0; 
        }

        public bool IsNonEmpty  
        {
             [MethodImpl(Inline)] 
             get => Location != 0; 
        }

        public Address16 Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static Address16 From(ushort offset)
            => new Address16(offset);

        [MethodImpl(Inline)]
        public static Address16 operator+(Address16 x, ushort y)
            => From((ushort)(x.Location + y));

        [MethodImpl(Inline)]
        public static bool operator==(Address16 x, Address16 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(Address16 x, Address16 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal Address16(ushort offset)
        {
            Location = offset;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Location.FormatSmallHex(true);
        
        public bool Equals(Address16 src)        
            => Location == src.Location;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Location.GetHashCode();
        
        public override bool Equals(object src)
            => src is Address16 l && Equals(l);
    }
}
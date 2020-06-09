//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Address32 : IAddress<Address32,W32,uint>
    {
        public uint Location {get;}

        public static Address32 Empty => new Address32(0);

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

        public Address32 Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static Address32 From(uint offset)
            => new Address32(offset);

        [MethodImpl(Inline)]
        public static Address32 operator+(Address32 x, uint y)
            => From((uint)(x.Location + y));

        [MethodImpl(Inline)]
        public static bool operator==(Address32 x, Address32 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(Address32 x, Address32 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal Address32(uint offset)
        {
            Location = offset;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Location.FormatSmallHex(true);
        
        public bool Equals(Address32 src)        
            => Location == src.Location;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Location.GetHashCode();
        
        public override bool Equals(object src)
            => src is Address32 l && Equals(l);
    }
}
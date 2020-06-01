//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Address64 : IAddress<Address64,W64,ulong>
    {
        public ulong Location {get;}

        public static Address64 Empty => new Address64(0);

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

        public Address64 Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static Address64 From(ulong offset)
            => new Address64(offset);

        [MethodImpl(Inline)]
        public static Address64 operator+(Address64 x, ulong y)
            => From((ulong)(x.Location + y));

        [MethodImpl(Inline)]
        public static bool operator==(Address64 x, Address64 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(Address64 x, Address64 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal Address64(ulong offset)
        {
            Location = offset;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Location.FormatSmallHex(true);
        
        public bool Equals(Address64 src)        
            => Location == src.Location;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Location.GetHashCode();
        
        public override bool Equals(object src)
            => src is Address64 l && Equals(l);
    }
}
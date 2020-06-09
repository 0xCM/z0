//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Address8 : IAddress<Address8,W8,byte>
    {
        public byte Location {get;}

        public static Address8 Empty => new Address8(0);

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

        public Address8 Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static Address8 From(byte offset)
            => new Address8(offset);

        [MethodImpl(Inline)]
        public static Address8 operator+(Address8 x, byte y)
            => From((byte)(x.Location + y));

        [MethodImpl(Inline)]
        public static bool operator==(Address8 x, Address8 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(Address8 x, Address8 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal Address8(byte offset)
        {
            Location = offset;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Location.FormatSmallHex(true);
        
        public bool Equals(Address8 src)        
            => Location == src.Location;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Location.GetHashCode();
        
        public override bool Equals(object src)
            => src is Address8 l && Equals(l);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using A = Address32;
    using W = W32;
    using T = System.UInt32;

    public readonly struct Address32 : IAddress<A,W,T>
    {
        public readonly T Location;

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

        public A Zero 
        {
             [MethodImpl(Inline)] 
             get => Empty; 
        }

        [MethodImpl(Inline)]
        public static implicit operator A(T src)
            => new A(src);

        [MethodImpl(Inline)]
        public static A operator+(A x, T y)
            => new A((T)(x.Location + y));

        [MethodImpl(Inline)]
        public static bool operator==(A x, A y)
            => x.Location == y.Location;

        [MethodImpl(Inline)]
        public static bool operator!=(A x, A y)
            => x.Location != y.Location;

        [MethodImpl(Inline)]
        public string Format()
            => Location.FormatSmallHex(true);
        
        [MethodImpl(Inline)]
        public bool Equals(A src)        
            => Location == src.Location;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Location.GetHashCode();
        
        public override bool Equals(object src)        
            => src is A a && Equals(a);
        
        public static A Empty 
            => new A(0);

        T IAddress<W,T>.Location 
            => Location;

        [MethodImpl(Inline)]
        public Address32(T offset)
            => Location = offset;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using A = Address16;
    using W = W16;
    using T = System.UInt16;

    public readonly struct Address16 : IAddress<A,W,T>
    {
        public readonly T Location;

        public static W W => default;

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
        public static implicit operator Address<W,T>(A src)
            => new Address<W,T>(src.Location);

        [MethodImpl(Inline)]
        public static implicit operator A(Address<W,T> src)
            => new A(src.Location);

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

        [MethodImpl(Inline)]
        public int CompareTo(A src)
            => Location == src.Location ? 0 : Location < src.Location ? -1 : 1;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => Location.GetHashCode();
        
        public override bool Equals(object src)        
            => src is A a && Equals(a);
        
        public static A Empty 
            => new A(0);

        T IAddress<T>.Location 
            => Location;

        [MethodImpl(Inline)]
        public Address16(T offset)
            => Location = offset;
    }
}
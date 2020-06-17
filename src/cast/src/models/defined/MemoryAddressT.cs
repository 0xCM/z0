//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemoryAddress<W,T> : IAddressable<W,T>, IIdentification<MemoryAddress>
        where W : unmanaged, INumericWidth
        where T : unmanaged
    {
        public static MemoryAddress<W,T> Zero => default;

        public T Location {get;}

        public NumericWidth Size
        {
            [MethodImpl(Inline)]
            get => Widths.numeric<W>();
        }

        ulong Location64 
        {
            [MethodImpl(Inline)]
            get => Cast.to<T,ulong>(Location);
        }

        public bool NonZero
        {
            [MethodImpl(Inline)]
            get => Location64 != 0;
        }

        public string IdentityText 
            => Cast.to<T,ulong>(Location).ToString("x") + "h";

        MemoryAddress IAddressable.Address 
        {
            [MethodImpl(Inline)]
            get => Location64;
        }

        [MethodImpl(Inline)]
        public static MemoryAddress<W64,ulong> Define(ulong location)
            => new MemoryAddress<W64,ulong>(location);

        [MethodImpl(Inline)]
        public static MemoryAddress<W32,uint> Define(uint location)
            => new MemoryAddress<W32,uint>(location);

        [MethodImpl(Inline)]
        public static MemoryAddress<W16,ushort> Define(ushort location)
            => new MemoryAddress<W16,ushort>(location);

        [MethodImpl(Inline)]
        public static explicit operator ushort(MemoryAddress<W,T> src)
            => (ushort)src.Location64;

        [MethodImpl(Inline)]
        public static explicit operator uint(MemoryAddress<W,T> src)
            => (uint)src.Location64;

        [MethodImpl(Inline)]
        public static explicit operator ulong(MemoryAddress<W,T> src)
            => src.Location64;

        [MethodImpl(Inline)]
        public static bool operator==(MemoryAddress<W,T> a, MemoryAddress<W,T> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryAddress<W,T> a, MemoryAddress<W,T> b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator<(MemoryAddress<W,T> a, MemoryAddress<W,T> b)
            => a.Location64 < b.Location64;

        [MethodImpl(Inline)]
        public static bool operator>(MemoryAddress<W,T> a, MemoryAddress<W,T> b)
            => a.Location64 > b.Location64;

        [MethodImpl(Inline)]
        public static bool operator<=(MemoryAddress<W,T> a, MemoryAddress<W,T> b)
            => a.Location64 <= b.Location64;

        [MethodImpl(Inline)]
        public static bool operator>=(MemoryAddress<W,T> a, MemoryAddress<W,T> b)
            => a.Location64 >= b.Location64;

        [MethodImpl(Inline)]
        public static MemoryAddress<W,T> operator+(MemoryAddress<W,T> a, MemoryAddress<W,T> b)
            => new MemoryAddress<W,T>(a.Location64 + b.Location64);

        [MethodImpl(Inline)]
        public static MemoryAddress<W,T> operator-(MemoryAddress<W,T> a, MemoryAddress<W,T> b)
            => new MemoryAddress<W,T>(a.Location64 - b.Location64);

        [MethodImpl(Inline)]
        MemoryAddress(ulong absolute)
            => this.Location = Cast.to<ulong,T>(absolute);

        public string Format()
            => IdentityText;

        public string Format(int digits)
            => Location64.ToString($"x{digits}") + "h";

        [MethodImpl(Inline)]
        public int CompareTo(MemoryAddress<W,T> other)
            => this == other ? 0 : this < other ? -1 : 1;

        [MethodImpl(Inline)]
        public bool Equals(MemoryAddress<W,T> src)
            => Location64 == src.Location64;

        public override int GetHashCode()
            => Location.GetHashCode();

        public override bool Equals(object obj)
            => obj is MemoryAddress a && Equals(a);                    

        public override string ToString() 
            => Format();

        [MethodImpl(Inline)]
        public unsafe P* ToPointer<P>()
            where P : unmanaged
                => (P*)Location64;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct MemoryAddress : IEquatable<MemoryAddress>, IComparable<MemoryAddress>
    {
        public static MemoryAddress Zero => default;

        public readonly ulong Location;

        public bool NonZero
        {
            [MethodImpl(Inline)]
            get => Location != 0;
        }

        [MethodImpl(Inline)]
        public static MemoryAddress Define(long location)
            => new MemoryAddress((ulong)location);

        [MethodImpl(Inline)]
        public static MemoryAddress Define(ulong location)
            => new MemoryAddress(location);

        [MethodImpl(Inline)]
        public static MemoryAddress Define(IntPtr location)
            => new MemoryAddress((ulong)location.ToInt64());

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(ulong src)
            => Define(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(MemoryAddress src)
            => src.Location;

        [MethodImpl(Inline)]
        public static implicit operator long(MemoryAddress src)
            => (long)src.Location;

        [MethodImpl(Inline)]
        public static bool operator==(MemoryAddress a, MemoryAddress b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(MemoryAddress a, MemoryAddress b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator<(MemoryAddress a, MemoryAddress b)
            => a.Location < b.Location;

        [MethodImpl(Inline)]
        public static bool operator>(MemoryAddress a, MemoryAddress b)
            => a.Location > b.Location;

        [MethodImpl(Inline)]
        public static bool operator<=(MemoryAddress a, MemoryAddress b)
            => a.Location <= b.Location;

        [MethodImpl(Inline)]
        public static bool operator>=(MemoryAddress a, MemoryAddress b)
            => a.Location >= b.Location;
            
        [MethodImpl(Inline)]
        MemoryAddress(ulong absolute)
        {
            this.Location = absolute;
        }
        

        // public override string ToString()
        //     => Format();         

        public override int GetHashCode()
            => Location.GetHashCode();

        [MethodImpl(Inline)]
        public bool Equals(MemoryAddress src)
            => Location == src.Location;

        public override bool Equals(object obj)
            => obj is MemoryAddress a && Equals(a);                    

        [MethodImpl(Inline)]
        public int CompareTo(MemoryAddress other)
            => this == other ? 0 : this < other ? -1 : 1;

        [MethodImpl(Inline)]
        public unsafe T* ToPointer<T>()
            where T : unmanaged
                => (T*)Location;         
    }
}
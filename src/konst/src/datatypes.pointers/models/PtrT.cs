//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Pointers;

    /// <summary>
    /// Captures and represents an <see cref='unmanaged'/> generic pointer
    /// </summary>
    public unsafe struct Ptr<T>
        where T : unmanaged
    {
        public T* P;

        [MethodImpl(Inline)]
        public Ptr(T* src)
            => P = src;


        public readonly MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => api.address<T>(P);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)((ulong)api.address<T>(P)).GetHashCode();
        }

        [MethodImpl(Inline)]
        public bool Equals(Ptr<T> src)
            => P == src.P;

        [MethodImpl(Inline)]
        public string Format()
            => api.format<T>(this);

        public override int GetHashCode()
            => (int)Hash;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static T operator !(Ptr<T> x)
            => *x.P;

        [MethodImpl(Inline)]
        public static Ptr<T> operator ++(Ptr<T> x)
            => api.next(x);

        [MethodImpl(Inline)]
        public static Ptr<T> operator --(Ptr<T> x)
            => api.prior(x);

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(Ptr<T> src)
            => src.Address;

        [MethodImpl(Inline)]
        public static implicit operator Ptr<T>(T* src)
            => new Ptr<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T*(Ptr<T> src)
            => src.P;
    }
}
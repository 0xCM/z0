//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Pointers;

    /// <summary>
    /// Captures and represents <see cref='ulong'/> pointer
    /// </summary>
    [ApiDeep]
    public unsafe struct Ptr64
    {
        public ulong* P;

        [MethodImpl(Inline)]
        public Ptr64(ulong* src)
            => P = src;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)((ulong)P).GetHashCode();
        }

        public readonly MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => api.address(P);
        }

        [MethodImpl(Inline)]
        public bool Equals(Ptr64 src)
            => P == src.P;

        [MethodImpl(Inline)]
        public string Format()
            => api.format<ulong>(this);

        public override int GetHashCode()
            => (int)Hash;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static ulong operator !(Ptr64 x)
            => *x.P;

        [MethodImpl(Inline)]
        public static Ptr64 operator ++(Ptr64 x)
            => api.next(x);

        [MethodImpl(Inline)]
        public static Ptr64 operator --(Ptr64 x)
            => api.prior(x);

        [MethodImpl(Inline)]
        public static implicit operator Ptr<ulong>(Ptr64 src)
            => new Ptr<ulong>(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(Ptr64 src)
            => src.Address;

        [MethodImpl(Inline)]
        public static implicit operator Ptr64(IntPtr src)
            => new Ptr64(src.ToPointer<ulong>());

        [MethodImpl(Inline)]
        public static explicit operator Ptr8(Ptr64 src)
            => new Ptr8((byte*)src.P);

        [MethodImpl(Inline)]
        public static explicit operator Ptr16(Ptr64 src)
            => new Ptr16((ushort*)src.P);

        [MethodImpl(Inline)]
        public static explicit operator Ptr32(Ptr64 src)
            => new Ptr32((uint*)src.P);

        [MethodImpl(Inline)]
        public static implicit operator Ptr64(ulong* src)
            => new Ptr64(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong*(Ptr64 src)
            => src.P;
    }
}
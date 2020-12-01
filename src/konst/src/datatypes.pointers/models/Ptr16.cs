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
    /// Captures and represents <see cref='ushort'/> pointer
    /// </summary>
    [ApiType]
    public unsafe struct Ptr16
    {
        public ushort* P;

        [MethodImpl(Inline)]
        public Ptr16(ushort* src)
            => P = src;

        [MethodImpl(Inline)]
        public static ushort operator !(Ptr16 x)
            => *x.P;

        [MethodImpl(Inline)]
        public static Ptr16 operator ++(Ptr16 x)
            => api.next(x);

        [MethodImpl(Inline)]
        public static Ptr16 operator --(Ptr16 x)
            => api.prior(x);

        [MethodImpl(Inline)]
        public static implicit operator Ptr<ushort>(Ptr16 src)
            => new Ptr<ushort>(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(Ptr16 src)
            => src.Address;

        [MethodImpl(Inline)]
        public static implicit operator Ptr16(ushort* src)
            => new Ptr16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort*(Ptr16 src)
            => src.P;

        public readonly MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => api.address(P);
        }

        [MethodImpl(Inline)]
        public bool Equals(Ptr16 src)
            => P == src.P;


        [MethodImpl(Inline)]
        public string Format()
            => api.format<ushort>(this);

        public override string ToString()
            => Format();
    }
}
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
    /// Captures and represents <see cref='byte'/> pointer
    /// </summary>
    [ApiType]
    public unsafe struct Ptr8
    {
        public byte* P;

        [MethodImpl(Inline)]
        public Ptr8(byte* src)
            => P = src;

        [MethodImpl(Inline)]
        public static byte operator !(Ptr8 x)
            => *x.P;

        [MethodImpl(Inline)]
        public static Ptr8 operator ++(Ptr8 x)
            => api.next(x);

        [MethodImpl(Inline)]
        public static Ptr8 operator --(Ptr8 x)
            => api.prior(x);

        [MethodImpl(Inline)]
        public static bool operator <(Ptr8 x, Ptr8 y)
            => x.P < y.P;

        [MethodImpl(Inline)]
        public static bool operator <=(Ptr8 x, Ptr8 y)
            => x.P <= y.P;

        [MethodImpl(Inline)]
        public static bool operator >(Ptr8 x, Ptr8 y)
            => x.P > y.P;

        [MethodImpl(Inline)]
        public static bool operator >=(Ptr8 x, Ptr8 y)
            => x.P >= y.P;

        [MethodImpl(Inline)]
        public static bool operator ==(Ptr8 x, Ptr8 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(Ptr8 x, Ptr8 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static implicit operator Ptr<byte>(Ptr8 src)
            => new Ptr<byte>(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(Ptr8 src)
            => src.Address;

        [MethodImpl(Inline)]
        public static implicit operator Ptr8(byte* src)
            => new Ptr8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte*(Ptr8 src)
            => src.P;

        public readonly MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => api.address(P);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)((ulong)P).GetHashCode();
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format<byte>(this);

        [MethodImpl(Inline)]
        public bool Equals(Ptr8 src)
            => P == src.P;

        public override bool Equals(object src)
            => src is Ptr8 p && Equals(p);

        public override int GetHashCode()
            => (int)Hash;

        public override string ToString()
            => Format();
    }
}
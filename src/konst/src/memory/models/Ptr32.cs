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
    /// Captures and represents <see cref='uint'/> pointer
    /// </summary>
    [ApiDataType]
    public unsafe struct Ptr32
    {
        public uint* P;

        [MethodImpl(Inline)]
        public Ptr32(uint* src)
            => P = src;

        [MethodImpl(Inline)]
        public static uint operator !(Ptr32 x)
            => *x.P;

        [MethodImpl(Inline)]
        public static Ptr32 operator ++(Ptr32 x)
            => api.next(x);

        [MethodImpl(Inline)]
        public static Ptr32 operator --(Ptr32 x)
            => api.prior(x);

        [MethodImpl(Inline)]
        public static implicit operator Ptr<uint>(Ptr32 src)
            => new Ptr<uint>(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(Ptr32 src)
            => src.Address;

        [MethodImpl(Inline)]
        public static implicit operator Ptr32(uint* src)
            => new Ptr32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint*(Ptr32 src)
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
        public bool Equals(Ptr32 src)
            => P == src.P;


        [MethodImpl(Inline)]
        public string Format()
            => api.format<uint>(this);

        public override int GetHashCode()
            => (int)Hash;

        public override string ToString()
            => Format();
    }
}
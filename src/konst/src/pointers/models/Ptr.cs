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
    /// Captures and represents a void pointer
    /// </summary>
    public unsafe struct Ptr
    {
        public void* P;

        [MethodImpl(Inline)]
        public Ptr(void* src)
            => P = src;

        [MethodImpl(Inline)]
        public static implicit operator Ptr(void* src)
            => new Ptr(src);

        [MethodImpl(Inline)]
        public static implicit operator void*(Ptr src)
            => src.P;

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(Ptr src)
            => src.Address;

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)((ulong)P).GetHashCode();
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => P;
        }

        [MethodImpl(Inline)]
        public bool Equals(Ptr src)
            => P == src.P;

        [MethodImpl(Inline)]
        public string Format()
            => api.format<ulong>((ulong*)this);

        public override int GetHashCode()
            => (int)Hash;

        public override string ToString()
            => Format();
    }
}
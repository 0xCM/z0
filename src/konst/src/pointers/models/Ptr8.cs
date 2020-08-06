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
    /// Models a <see cref='byte'/> pointer
    /// </summary>
    [ApiDataType]
    public unsafe struct Ptr8
    {
        public byte* P;

        [MethodImpl(Inline)]
        public Ptr8(byte* src)
            => P = src;

        [MethodImpl(Inline)]
        public static implicit operator Ptr8(byte* src)
            => new Ptr8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte*(Ptr8 src)
            => src.P;

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(Ptr8 src)
            => api.address(src);
    }
}
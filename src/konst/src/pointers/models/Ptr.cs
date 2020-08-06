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
    /// Models a void pointer
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
            => api.address(src);
    }
}
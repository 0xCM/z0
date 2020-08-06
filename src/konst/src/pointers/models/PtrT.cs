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
    /// Models a generic pointer
    /// </summary>
    public unsafe struct Ptr<T>
        where T : unmanaged
    {
        public T* P;    

        [MethodImpl(Inline)]
        public Ptr(T* src)
            => P = src;

        [MethodImpl(Inline)]
        public static implicit operator Ptr<T>(T* src)
            => new Ptr<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T*(Ptr<T> src)
            => src.P;

        [MethodImpl(Inline)]
        public static implicit operator MemoryAddress(Ptr<T> src)
            => api.address(src);
    }
}
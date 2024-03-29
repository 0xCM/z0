//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    static class VslSSTaskHandle
    {
        [MethodImpl(Inline)]
        public static unsafe VslSSTaskHandle<T> Create<T>(Span<T> samples, int dim)
            where T : unmanaged
                => VslSSTaskHandle<T>.Create(samples,dim);

        [MethodImpl(Inline)]
        public static unsafe VslSSTaskHandle<T> Create<T>(Observations<T> samples)
            where T : unmanaged
                => VslSSTaskHandle<T>.Create(samples);

        [MethodImpl(Inline)]
        public static VslSSTaskHandle<T> Wrap<T>(IntPtr ptr)
            where T : unmanaged
                => VslSSTaskHandle<T>.Wrap(ptr);
    }
}
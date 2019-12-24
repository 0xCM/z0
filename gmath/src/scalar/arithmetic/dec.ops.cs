//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KdecOp<T> : IUnaryOp<T>
        where T : unmanaged        
    {
        public static KdecOp<T> Op => default;

        public string Moniker => moniker<T>("dec");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.dec(x);
    }


    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KdecOp<T> dec<T>()
            where T : unmanaged        
                => KdecOp<T>.Op;

    }
}
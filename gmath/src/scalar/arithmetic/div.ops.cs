//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KdivOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        public static KdivOp<T> Op => default;

        public string Moniker => moniker<T>("div");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.div(x,y);
    }

    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KdivOp<T> div<T>()
            where T : unmanaged        
                => KdivOp<T>.Op;
    }

}
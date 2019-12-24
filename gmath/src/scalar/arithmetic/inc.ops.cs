//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KincOp<T> : IUnaryOp<T>
        where T : unmanaged        
    {        
        public static KincOp<T> Op => default;

        public string Moniker => moniker<T>("inc");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.inc(x);
    }

    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KincOp<T> inc<T>()
            where T : unmanaged        
                => KincOp<T>.Op;
    }

}
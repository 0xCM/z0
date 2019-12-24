//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KmulOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {    
        public static KmulOp<T> Op => default;

        public string Moniker => moniker<T>("mul");


        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.mul(x,y);
    }

    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KmulOp<T> mul<T>()
            where T : unmanaged        
                => KmulOp<T>.Op;
    }

}
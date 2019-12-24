//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KandOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {    
        public static KandOp<T> Op => default;

        public string Moniker => moniker<T>("and");


        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.and(x,y);
    }

    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KandOp<T> and<T>()
            where T : unmanaged        
                => KandOp<T>.Op;
    }
}
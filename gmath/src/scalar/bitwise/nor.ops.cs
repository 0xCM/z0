//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KnorOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {    
        public static KnorOp<T> Op => default;

        public string Moniker => moniker<T>("nor");


        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.nor(x,y);
    }

    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KnorOp<T> nor<T>()
            where T : unmanaged        
                => KnorOp<T>.Op;
    }
}
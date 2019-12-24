//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct DivOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        public static DivOp<T> Op => default;

        public string Moniker => moniker<T>("div");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.div(x,y);
    }


}
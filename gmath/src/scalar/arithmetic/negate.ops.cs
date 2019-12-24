//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;
    

    public readonly struct KnegateOp<T> : IUnaryOp<T>
        where T : unmanaged        
    {
        public static KnegateOp<T> Op => default;

        public string Moniker => moniker<T>("negate");        

        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.negate(x);
    }


    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KnegateOp<T> negate<T>()
            where T : unmanaged        
                => KnegateOp<T>.Op;
    }
}
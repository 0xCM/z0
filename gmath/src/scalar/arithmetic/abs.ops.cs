//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KabsOp<T>  : IUnaryOp<T>
        where T : unmanaged        
    {
        public static KabsOp<T> Op => default;

        public string Moniker => moniker<T>("abs");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.abs(x);
    }

    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KabsOp<T> abs<T>()
            where T : unmanaged        
                => KabsOp<T>.Op;
    }


}
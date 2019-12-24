//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KnotOp<T> : IPUnaryOp<T>
        where T : unmanaged        
    {
        public static KnotOp<T> Op => default;

        public string Moniker => moniker<T>("not");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.not(x);
    }    

    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KnotOp<T> not<T>()
            where T : unmanaged        
                => KnotOp<T>.Op;
    }
}
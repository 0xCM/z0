//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KmodOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        public static KmodOp<T> Op => default;

        public string Moniker => moniker<T>("mod");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.mod(x,y);
    }

    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KmodOp<T> mod<T>()
            where T : unmanaged        
                => KmodOp<T>.Op;

    }
}
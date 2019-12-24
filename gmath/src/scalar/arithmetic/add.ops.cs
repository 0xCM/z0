//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KaddOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        public static KaddOp<T> Op => default;

        public string Moniker => moniker<T>("add");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.add(x,y);
    }


    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KaddOp<T> add<T>()
            where T : unmanaged        
                => KaddOp<T>.Op;
    }
}
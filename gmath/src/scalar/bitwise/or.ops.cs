//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KorOp<T> : IPBinOp<T>
        where T : unmanaged        
    {    
        public static KorOp<T> Op => default;

        public string Moniker => moniker<T>("or");


        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.or(x,y);
    }

    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KorOp<T> or<T>()
            where T : unmanaged        
                => KorOp<T>.Op;
    }
}
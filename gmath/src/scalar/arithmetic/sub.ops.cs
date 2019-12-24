//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    public readonly struct KsubOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        public static KsubOp<T> Op => default;

        public string Moniker => moniker<T>("sub");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.sub(x,y);
    }

    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KsubOp<T> sub<T>()
            where T : unmanaged        
                => KsubOp<T>.Op;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    public readonly struct KeqOp<T> : IPBinaryPred<T>
        where T : unmanaged        
    {
        public static KeqOp<T> Op => default;

        public string Moniker => moniker<T>("eq");

        [MethodImpl(Inline)]
        public readonly bit Invoke(T x, T y)
            => gmath.eq(x,y);
    }

    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KeqOp<T> eq<T>()
            where T : unmanaged        
                => KeqOp<T>.Op;
    }
}
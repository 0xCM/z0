//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    public readonly struct KgtOp<T> : IPBinaryPred<T>
        where T : unmanaged        
    {
        public static KgtOp<T> Op => default;

        public string Moniker => moniker<T>("gt");

        [MethodImpl(Inline)]
        public readonly bit Invoke(T x, T y)
            => gmath.gt(x,y);
    }

    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KgtOp<T> gt<T>()
            where T : unmanaged        
                => KgtOp<T>.Op;
    }
}
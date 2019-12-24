//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    public readonly struct KltOp<T> : IPBinaryPred<T>
        where T : unmanaged        
    {
        public static KltOp<T> Op => default;

        public string Moniker => moniker<T>("lt");

        [MethodImpl(Inline)]
        public readonly bit Invoke(T x, T y)
            => gmath.lt(x,y);
    }

    partial class KOps
    {
        [MethodImpl(Inline)]
        public static KltOp<T> lt<T>()
            where T : unmanaged        
                => KltOp<T>.Op;
    }
}
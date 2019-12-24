//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    partial class MathOps
    {


    }

    public readonly struct AbsOp<T>  : IUnaryOp<T>
        where T : unmanaged        
    {
        public static AbsOp<T> Op => default;

        public string Moniker => moniker<T>("abs");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.abs(x);
    }

}
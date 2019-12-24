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

    public readonly struct IncOp<T> : IUnaryOp<T>
        where T : unmanaged        
    {        
        public static IncOp<T> Op => default;

        public string Moniker => moniker<T>("inc");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.inc(x);
    }



}
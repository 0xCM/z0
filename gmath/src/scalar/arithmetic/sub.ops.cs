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

    public readonly struct SubOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        public static SubOp<T> Op => default;

        public string Moniker => moniker<T>("sub");

        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.sub(x,y);
    }


}
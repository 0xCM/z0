//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public readonly struct KxorOp<T> : IPBinOp<T>
        where T : unmanaged        
    {    
        public static KxorOp<T> Op => default;

        public string Moniker => moniker<T>("xor");


        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.xor(x,y);
    }

    partial class KOps
    {

        [MethodImpl(Inline)]
        public static KandOp<T> xor<T>()
            where T : unmanaged        
                => default;
    }
}
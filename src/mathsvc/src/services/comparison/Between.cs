//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;
    using static Structured;

    partial class MathSvcTypes
    {
        [Closures(NumericKind.All)]
        public readonly struct Between<T> : ISFunc<T,T,T,bit>
            where T : unmanaged        
        {
            public const string Name = "between";

            public static Between<T> Op => default;

            public OpIdentity Id => Identify.sfunc<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T a, T b) 
                => gmath.between(x,a,b);
        }
    }
}
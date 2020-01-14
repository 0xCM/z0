//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class GXTypes
    {
        public readonly struct Eq<T> : IBinaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "eq";

            public static Eq<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.eq(x,y);
        }

        public readonly struct Neq<T> : IBinaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "neq";

            public static Neq<T> Op => default;
            
            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.neq(x,y);
        }

        public readonly struct Lt<T> : IBinaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "lt";

            public static Lt<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.lt(x,y);
        }

        public readonly struct LtEq<T> : IBinaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "lteq";

            public static LtEq<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.lteq(x,y);
        }

        public readonly struct Gt<T> : IBinaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "gt";

            public static Gt<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a, T b) => gmath.gt(a,b);
        }

        public readonly struct GtEq<T> : IBinaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "gteq";

            public static GtEq<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a, T b) => gmath.gteq(a,b);
        }

        public readonly struct Between<T> : ITernaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "between";

            public static Between<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T a, T b) => gmath.between(x,a,b);
        }

        public readonly struct Nonz<T> : IUnaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "nonz";

            public static Nonz<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => gmath.nonz(a);
        }

        public readonly struct NegativeOp<T> : IUnaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "negative";

            public static NegativeOp<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => gmath.negative(a);
        }

        public readonly struct PositiveOp<T> : IUnaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "positive";

            public static PositiveOp<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => gmath.positive(a);
        }

        public readonly struct Min<T> : IBinaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "min";

            public static Min<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.min(a, b);
        }

        public readonly struct Max<T> : IBinaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "max";

            public static Max<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.max(a, b);
        }

    }
}
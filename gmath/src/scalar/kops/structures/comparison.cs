//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class KOpStructs
    {
        public readonly struct Eq<T> : IPrimalBinaryPred<T>
            where T : unmanaged        
        {
            public static Eq<T> Op => default;

            public const string Name = "eq";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.eq(x,y);
        }

        public readonly struct Neq<T> : IPrimalBinaryPred<T>
            where T : unmanaged        
        {
            public static Neq<T> Op => default;

            public const string Name = "neq";
            
            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.neq(x,y);
        }

        public readonly struct Lt<T> : IPrimalBinaryPred<T>
            where T : unmanaged        
        {
            public static Lt<T> Op => default;

            public const string Name = "lt";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.lt(x,y);
        }

        public readonly struct LtEq<T> : IPrimalBinaryPred<T>
            where T : unmanaged        
        {
            public static LtEq<T> Op => default;

            public const string Name = "lteq";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T y) => gmath.lteq(x,y);
        }

        public readonly struct Gt<T> : IPrimalBinaryPred<T>
            where T : unmanaged        
        {
            public static Gt<T> Op => default;

            public const string Name = "gt";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a, T b) => gmath.gt(a,b);
        }

        public readonly struct GtEq<T> : IPrimalBinaryPred<T>
            where T : unmanaged        
        {
            public static GtEq<T> Op => default;

            public const string Name = "gteq";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a, T b) => gmath.gteq(a,b);
        }


        public readonly struct Between<T> : IPrimalTernaryPred<T>
            where T : unmanaged        
        {
            public static Between<T> Op => default;

            public const string Name = "between";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T x, T a, T b) => gmath.between(x,a,b);
        }

        public readonly struct Nonz<T> : IPrimalUnaryPred<T>
            where T : unmanaged        
        {
            public static Nonz<T> Op => default;

            public const string Name = "nonz";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => gmath.nonz(a);
        }

        public readonly struct NegativeOp<T> : IPrimalUnaryPred<T>
            where T : unmanaged        
        {
            public static NegativeOp<T> Op => default;

            public const string Name = "negative";

            public string Moniker => moniker<T>("negative");

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => gmath.negative(a);
        }

        public readonly struct PositiveOp<T> : IPrimalUnaryPred<T>
            where T : unmanaged        
        {
            public static PositiveOp<T> Op => default;

            public const string Name = "positive";

            public string Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => gmath.positive(a);
        }

    }
}
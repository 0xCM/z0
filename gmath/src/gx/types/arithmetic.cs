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
        public readonly struct Add<T> : IBinaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "add";

            public static Add<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.add(a, b);
        }

        public readonly struct Sub<T> : IBinaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "sub";

            public static Sub<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.sub(a,b);
        }

        public readonly struct Mul<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public const string Name = "mul";

            public static Mul<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);


            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.mul(a, b);
        }

        public readonly struct Div<T> : IBinaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "div";

            public static Div<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.div(a, b);
        }

        public readonly struct ModOp<T> : IBinaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "mod";

            public static ModOp<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.mod(a,b);
        }

        public readonly struct ModMul<T> : ITernaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "modmul";

            public static ModMul<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b, T m) => gmath.modmul(a,b,m);
        }


        public readonly struct Even<T> : IUnaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "even";

            public static Even<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => gmath.even(a);
        }

        public readonly struct Odd<T> : IUnaryPred<T>
            where T : unmanaged        
        {
            public const string Name = "odd";

            public static Odd<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly bit Invoke(T a) => gmath.odd(a);
        }

        public readonly struct Clamp<T> : IBinaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "clamp";

            public static Clamp<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.clamp(a,b);
        }

        public readonly struct Square<T> : IUnaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "square";

            public static Square<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.square(a);
        }
    
        public readonly struct Negate<T> : IUnaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "negate";

            public static Negate<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.negate(a);
        }
    

        public readonly struct Dec<T> : IUnaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "dec";

            public static Dec<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.dec(a);
        }

        public readonly struct Inc<T> : IUnaryOp<T>
            where T : unmanaged        
        {        
            public const string Name = "inc";

            public static Inc<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.inc(a);
        }

        public readonly struct Abs<T>  : IUnaryOp<T>
            where T : unmanaged        
        {
            public const string Name = "abs";

            public static Abs<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.abs(a);
        }

        public readonly struct Dist<T> : IFunc<T,T,ulong>
            where T : unmanaged        
        {
            public const string Name = "dist";

            public static Dist<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly ulong Invoke(T a, T b) => gmath.dist(a,b);
        }

    }
}
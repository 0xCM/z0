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
        public readonly struct And<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static And<T> Op => default;

            public const string Name = "and";

            public Moniker Moniker => moniker<T>(Name);


            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.and(a,b);
        }

        public readonly struct Or<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static Or<T> Op => default;

            public const string Name = "or";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.or(a,b);
        }

        public readonly struct Xor<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static Xor<T> Op => default;

            public const string Name = "xor";

            public Moniker Moniker => moniker<T>(Name);


            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.xor(a,b);
        }

        public readonly struct Nand<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static Nand<T> Op => default;

            public const string Name = "nand";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.nand(a,b);
        }

        public readonly struct Nor<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static Nor<T> Op => default;

            public const string Name = "not";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.nor(a,b);
        }

        public readonly struct Xnor<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static Xnor<T> Op => default;

            public const string Name = "xnor";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.xnor(a, b);
        }

        public readonly struct Select<T> : ITernaryOp<T>
            where T : unmanaged        
        {    
            public static Select<T> Op => default;

            public const string Name = "select";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b, T c) => gmath.select(a, b, c);
        }

        public readonly struct Not<T> : IUnaryOp<T>
            where T : unmanaged        
        {
            public static Not<T> Op => default;

            public const string Name = "not";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.not(a);
        }    

        public readonly struct CImpl<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static CImpl<T> Op => default;

            public const string Name = "cimpl";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.cimpl(a,b);
        }

        public readonly struct CNonImpl<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static CNonImpl<T> Op => default;

            public const string Name = "cnonimpl";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.cnonimpl(a,b);
        }

        public readonly struct Impl<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static Impl<T> Op => default;

            public const string Name = "impl";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.impl(a,b);
        }

        public readonly struct NonImpl<T> : IBinaryOp<T>
            where T : unmanaged        
        {    
            public static NonImpl<T> Op => default;

            public const string Name = "impl";

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.nonimpl(a,b);
        }

    }

}
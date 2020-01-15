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

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct And<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "and";

            public static And<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);


            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.and(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Or<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "or";

            public static Or<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.or(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Xor<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "xor";

            public static Xor<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);


            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.xor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Nand<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "nand";

            public static Nand<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.nand(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Nor<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "not";

            public static Nor<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.nor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Xnor<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "xnor";

            public static Xnor<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.xnor(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Select<T> : ITernaryOp<T>, ITernarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "select";

            public static Select<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b, T c) => gmath.select(a, b, c);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
                => TernaryFunc.apply(this, a,b,c,dst);

        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Not<T> : IUnaryOp<T>, IUnarySpanOp<T>
            where T : unmanaged        
        {
            public const string Name = "not";

            public static Not<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a) => gmath.not(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => UnaryFunc.apply(this, src, dst);
        }    

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct Impl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "impl";

            public static Impl<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.impl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);
        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct NonImpl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "impl";

            public static NonImpl<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.nonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);

        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct CImpl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "cimpl";

            public static CImpl<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.cimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);

        }

        [PrimalClosures(PrimalKind.Integers)]
        public readonly struct CNonImpl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "cnonimpl";

            public static CNonImpl<T> Op => default;

            public Moniker Moniker => moniker<T>(Name);

            [MethodImpl(Inline)]
            public readonly T Invoke(T a, T b) => gmath.cnonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => BinaryFunc.apply(this, lhs,rhs,dst);

        }
    }
}
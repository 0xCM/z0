//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;

    partial class GXTypes
    {
        [NumericClosures(NumericKind.Integers)]
        public readonly struct And<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "and";

            public static And<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.and(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => mathspan.and(l,r,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Or<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "or";

            public static Or<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.or(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => mathspan.or(l,r,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Xor<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "xor";

            public static Xor<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.xor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => mathspan.xor(l,r,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Nand<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "nand";

            public static Nand<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nand(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => mathspan.nand(l,r,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Nor<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "not";

            public static Nor<T> Op => default;
            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => mathspan.nor(l,r,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Xnor<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "xnor";

            public static Xnor<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.xnor(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => mathspan.nor(l,r,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Select<T> : ITernaryOp<T>, ITernarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "select";

            public static Select<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) 
                => gmath.select(a, b, c);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
                => mathspan.select(a,b,c,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Not<T> : IUnaryOp<T>, IUnarySpanOp<T>
            where T : unmanaged        
        {
            public const string Name = "not";

            public static Not<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) 
                => gmath.not(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => mathspan.not(src,dst);
        }    

        [NumericClosures(NumericKind.Integers)]
        public readonly struct Impl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "impl";

            public static Impl<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.impl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => mathspan.impl(lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct NonImpl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "impl";

            public static NonImpl<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => mathspan.nonimpl(lhs,rhs,dst);

        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct CImpl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "cimpl";

            public static CImpl<T> Op => default;

            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.cimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => mathspan.cimpl(lhs,rhs,dst);
        }

        [NumericClosures(NumericKind.Integers)]
        public readonly struct CNonImpl<T> : IBinaryOp<T>, IBinarySpanOp<T>
            where T : unmanaged        
        {    
            public const string Name = "cnonimpl";

            public static CNonImpl<T> Op => default;
            
            public OpIdentity Id => OpIdentity.contracted<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.cnonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => mathspan.cnonimpl(lhs,rhs,dst);
        }
    }
}
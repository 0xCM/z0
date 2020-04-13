//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed; using static Memories;

    partial class MathSvcTypes
    {
        [Closures(Integers)]
        public readonly struct And<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "and";

            public static And<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.and(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.and(l,r,dst);
        }

        [Closures(Integers)]
        public readonly struct Or<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "or";

            public static Or<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.or(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.or(l,r,dst);
        }

        [Closures(Integers)]
        public readonly struct Xor<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "xor";

            public static Xor<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.xor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.xor(l,r,dst);
        }

        [Closures(Integers)]
        public readonly struct Nand<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "nand";

            public static Nand<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nand(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.nand(l,r,dst);
        }

        [Closures(Integers)]
        public readonly struct Nor<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "not";

            public static Nor<T> Op => default;
            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nor(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.nor(l,r,dst);
        }

        [Closures(Integers)]
        public readonly struct Xnor<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "xnor";

            public static Xnor<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.xnor(a, b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
                => gspan.nor(l,r,dst);
        }

        [Closures(Integers)]
        public readonly struct Select<T> : ISTernaryOpApi<T>, ISTernarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "select";

            public static Select<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b, T c) 
                => gmath.select(a, b, c);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
                => gspan.select(a,b,c,dst);
        }

        [Closures(Integers)]
        public readonly struct Not<T> : ISUnaryOpApi<T>, ISUnarySpanOpApi<T>
            where T : unmanaged        
        {
            public const string Name = "not";

            public static Not<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a) 
                => gmath.not(a);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> src, Span<T> dst)
                => gspan.not(src,dst);
        }    

        [Closures(Integers)]
        public readonly struct Impl<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "impl";

            public static Impl<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.impl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.impl(lhs,rhs,dst);
        }

        [Closures(Integers)]
        public readonly struct NonImpl<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "impl";

            public static NonImpl<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.nonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.nonimpl(lhs,rhs,dst);

        }

        [Closures(Integers)]
        public readonly struct CImpl<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "cimpl";

            public static CImpl<T> Op => default;

            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.cimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.cimpl(lhs,rhs,dst);
        }

        [Closures(Integers)]
        public readonly struct CNonImpl<T> : ISBinaryOpApi<T>, ISBinarySpanOpApi<T>
            where T : unmanaged        
        {    
            public const string Name = "cnonimpl";

            public static CNonImpl<T> Op => default;
            
            public OpIdentity Id => Identify.sFunc<T>(Name);

            [MethodImpl(Inline)]
            public T Invoke(T a, T b) 
                => gmath.cnonimpl(a,b);

            [MethodImpl(Inline)]
            public Span<T> Invoke(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
                => gspan.cnonimpl(lhs,rhs,dst);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        [MethodImpl(Inline)]
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.add<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.sub<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.mul<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.div<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.mod<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => UnaryFunc.apply(GX.negate<T>(), src, dst);

        [MethodImpl(Inline)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => UnaryFunc.apply(GX.inc<T>(), src,dst);

        [MethodImpl(Inline)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => UnaryFunc.apply(GX.dec<T>(), src,dst);

        [MethodImpl(Inline)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => UnaryFunc.apply(GX.abs<T>(), src, dst);

        [MethodImpl(Inline)]
        public static Span<bit> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.eq<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<bit> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.neq<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<bit> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.gt<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<bit> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.gteq<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<bit> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.lt<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<bit> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bit> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.lteq<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.and<T>(), lhs,rhs,dst);

        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.or<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.xor<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> nor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.nor<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> xnor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.xnor<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => UnaryFunc.apply(GX.not<T>(), src, dst);

        [MethodImpl(Inline)]
        public static Span<T> nand<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.nand<T>(), lhs, rhs, dst);

        [MethodImpl(Inline)]
        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
                => BinaryFunc.apply(GX.cnonimpl<T>(), lhs, rhs, dst);

        public static Span<T> pow<T>(ReadOnlySpan<T> src, uint exp, Span<T> dst)
            where T : unmanaged
        {
            var len =  length(src,dst);
            for(var i = 0; i<len; i++) 
                dst[i] = gmath.pow(src[i], exp);
            return dst;
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T dot<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            var dst = default(T);
            for(var i = 0; i< count; i++)
                dst = gmath.fma(lhs[i], rhs[i], dst);
            return dst;                
        }

        public static T min<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(src.IsEmpty)
                return default(T);
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(gmath.lt(src[i], result))
                    result = src[i];

            return result;
        }

        public static T max<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(src.IsEmpty)
                return default;
            
            var result = src[0];
            for(var i = 1; i< src.Length; i++)
                if(gmath.gt(src[i], result))
                    result = src[i];
            
            return result;
        }

        [MethodImpl(Inline)]
        public static T max<T>(Span<T> src)
            where T : unmanaged
                => max(src.ReadOnly());
    }
}
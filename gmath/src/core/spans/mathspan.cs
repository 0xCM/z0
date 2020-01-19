//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    using static As;  

    partial class mathspan
    {
        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> add<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.add<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> sub<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.sub<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> mul<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.mul<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> div<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.div<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> mod<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.mod<T>(), l, r, dst);

        [MethodImpl(Inline), PrimalClosures(PrimalKind.Integers)]
        public static Span<T> modmul<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.modmul<T>(), a,b,c, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> clamp<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.clamp<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.negate<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.inc<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.dec<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> square<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.square<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.abs<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<bit> eq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.eq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<bit> neq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.neq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<bit> lt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.lt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<bit> lteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.lteq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<bit> gt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.gt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<bit> gteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.gteq<T>(), l, r, dst);

        [MethodImpl(Inline)]
        public static Span<bit> even<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.even<T>(), src,dst);

        [MethodImpl(Inline)]
        public static Span<bit> odd<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.odd<T>(), src,dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> and<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.and<T>(), l,r,dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> or<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.or<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> xor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.xor<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> nand<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.nand<T>(), l,r,dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> nor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.nor<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> xnor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.xnor<T>(), l, r, dst);


        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> impl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.impl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> nonimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.nonimpl<T>(), l, r, dst);


        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> cimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.cimpl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.cnonimpl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> select<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.select<T>(), a, b, c, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => SpanFunc.apply(GX.not<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> srl<T>(ReadOnlySpan<T> src, byte count, Span<T> dst)
            where T : unmanaged
        {            
            var len = dst.Length;
            ref readonly var input = ref head(src);
            ref var target = ref head(dst);
            for(var i = 0; i<len; i++) 
                seek(ref target,i) = gmath.srl(skip(input,i), count);                
            return dst;
        }                

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> srlv<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> counts, Span<T> dst)
            where T : unmanaged
        {
            var len = dst.Length;
            ref readonly var input = ref head(src);
            ref readonly var count = ref head(counts);
            ref var target = ref head(dst);
            for(var i=0; i < len; i++)
                seek(ref target,i) = gmath.srl(skip(input,i), convert<T,byte>(skip(count,i)));
            return dst;
        }

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> sll<T>(ReadOnlySpan<T> src, byte count, Span<T> dst)
            where T : unmanaged
        {            
            var len = dst.Length;
            ref readonly var input = ref head(src);
            ref var target = ref head(dst);
            for(var i = 0; i<len; i++) 
                seek(ref target,i) = gmath.sll(skip(input,i), count);                
            return dst;
        }                

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.Integers)]
        public static Span<T> sllv<T>(ReadOnlySpan<T> src, ReadOnlySpan<T> counts, Span<T> dst)
            where T : unmanaged
        {
            var len = dst.Length;
            ref readonly var input = ref head(src);
            ref readonly var count = ref head(counts);
            ref var target = ref head(dst);
            for(var i=0; i < len; i++)
                seek(ref target,i) = gmath.sll(skip(input,i), convert<T,byte>(skip(count,i)));
            return dst;
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal scalar type</typeparam>
        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static T dot<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var count = lhs.Length;
            ref readonly var lSrc = ref head(lhs);
            ref readonly var rSrc = ref head(rhs);

            var dst = default(T);
            for(var i = 0; i< count; i++)
                dst = gmath.fma(skip(lSrc, i), skip(rSrc,i), dst);
            return dst;                
        }

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static Span<T> pow<T>(ReadOnlySpan<T> src, uint exp, Span<T> dst)
            where T : unmanaged
        {
            var count = dst.Length;
            ref readonly var bases = ref head(src);
            ref var results = ref head(dst);

            for(var i = 0; i<count; i++) 
                seek(ref results,i) = gmath.pow(skip(bases,i), exp);
            
            return dst;
        }

        [MethodImpl(Inline), SpanOp, PrimalClosures(PrimalKind.All)]
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => avg_u(src);

        [MethodImpl(Inline)]
        public static T avg<T>(Span<T> src)
            where T : unmanaged
                => avg(src.ReadOnly());

        [MethodImpl(Inline)]
        public static T avgz<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            ref readonly var reader = ref head(src);
            T result = reader;
            for(var i=1; i<src.Length; i++)
                result = gmath.avgz(result, skip(in reader, i));
            return result;
        }

        [MethodImpl(Inline)]
        public static T avgz<T>(Span<T> src)
            where T : unmanaged
                => avgz(src.ReadOnly());

        public static Span<byte> avgi(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)        
        {
            Span<byte> dst = new byte[length(lhs,rhs)];
            for(var i=0; i<dst.Length; i++)
                dst[i] = math.avgi(lhs[i],rhs[i]);
            return dst;
        }

        public static Span<ushort> avgi(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)        
        {
            Span<ushort> dst = new ushort[length(lhs,rhs)];
            for(var i=0; i<dst.Length; i++)
                dst[i] = math.avgi(lhs[i],rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static T avg_u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.avg_checked(span8u(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.avg_checked(span16u(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.avg_checked(span32u(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.avg_checked(span64u(src)));
            else
                return avg_i(src);
        }           

        [MethodImpl(Inline)]
        static T avg_i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.avg_checked(span8i(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.avg_checked(span16i(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.avg_checked(span32i(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.avg_checked(span64i(src)));
            else
                return fspan.avg(src);
        }           

        [MethodImpl(Inline)]
        public static T sum<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            checked
            {
                var count = src.Length;
                ref readonly var input = ref head(src);
                var result = default(T);

                for(var i=0; i< src.Length; i++)
                    result = gmath.add(result, skip(input,i));
                return result;
            }
        }

        [MethodImpl(Inline)]
        public static T sum<T>(Span<T> src)
            where T : unmanaged
                => sum(src.ReadOnly());


        [MethodImpl(Inline)]
        public static T min<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            if(count == 0)
                return default;
            
            ref readonly var input = ref head(src);
            var result = input;

            for(var i = 1; i< count; i++)
            {
                ref readonly var test = ref skip(in input, i);
                if(gmath.lt(test, result))
                    result = test;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static T max<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var count = src.Length;
            if(count == 0)
                return default;
            
            ref readonly var input = ref head(src);
            var result = input;

            for(var i = 1; i< count; i++)
            {
                ref readonly var test = ref skip(in input, i);
                if(gmath.gt(test, result))
                    result = test;
            }

            return result;
        }

        [MethodImpl(Inline)]
        public static T max<T>(Span<T> src)
            where T : unmanaged
                => max(src.ReadOnly());       
    }
}
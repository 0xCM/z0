//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;
    using static As;  

    [ApiHost(ApiHostKind.Generic)]
    public static class mathspan
    {
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> add<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.add<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> sub<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.sub<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> mul<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.mul<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> div<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.div<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> mod<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.mod<T>(), l, r, dst);

        [MethodImpl(Inline), NumericClosures(NumericKind.Integers)]
        public static Span<T> modmul<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.modmul<T>(), a,b,c, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> clamp<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.clamp<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.negate<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.inc<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.dec<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> square<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.square<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.abs<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> eq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => Spans.apply(GX.eq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> neq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => Spans.apply(GX.neq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> lt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => Spans.apply(GX.lt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> lteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => Spans.apply(GX.lteq<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> gt<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => Spans.apply(GX.gt<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<bit> gteq<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<bit> dst)
            where T : unmanaged
                => Spans.apply(GX.gteq<T>(), l, r, dst);

        [MethodImpl(Inline)]
        public static Span<bit> even<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => Spans.apply(GX.even<T>(), src,dst);

        [MethodImpl(Inline)]
        public static Span<bit> odd<T>(ReadOnlySpan<T> src, Span<bit> dst)
            where T : unmanaged
                => Spans.apply(GX.odd<T>(), src,dst);

        /// <summary>
        /// Computes the bitwise and between corresponding span elements
        /// </summary>
        /// <param name="l">The left source span</param>
        /// <param name="r">The right source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> and<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.and<T>(), l,r,dst);

        /// <summary>
        /// Computes the bitwise or between corresponding span elements
        /// </summary>
        /// <param name="l">The left source span</param>
        /// <param name="r">The right source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> or<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.or<T>(), l, r, dst);

        /// <summary>
        /// Computes the aggregate bitwise or of the source elements
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static T or<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            var result = default(T);
            for(var i=0; i<src.Length; i++)
                result = GX.or<T>().Invoke(result, skip(src,i));
            return result;
        }                

        /// <summary>
        /// Computes the bitwise xor between corresponding span elements
        /// </summary>
        /// <param name="l">The left source span</param>
        /// <param name="r">The right source span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> xor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.xor<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> nand<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.nand<T>(), l,r,dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> nor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.nor<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> xnor<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.xnor<T>(), l, r, dst);


        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> impl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.impl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> nonimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.nonimpl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> cimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.cimpl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> l, ReadOnlySpan<T> r, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.cnonimpl<T>(), l, r, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> select<T>(ReadOnlySpan<T> a, ReadOnlySpan<T> b, ReadOnlySpan<T> c, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.select<T>(), a, b, c, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> not<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
                => Spans.apply(GX.not<T>(), src, dst);

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
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

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
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

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> sllv<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
            where T : unmanaged
        {
            var len = dst.Length;
            ref readonly var input = ref head(src);
            ref readonly var count = ref head(counts);
            ref var target = ref head(dst);
            
            for(var i=0; i < len; i++)
                seek(ref target,i) = gmath.sll(skip(input,i), skip(count,i));
            return dst;
        }

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.Integers)]
        public static Span<T> srlv<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> counts, Span<T> dst)
            where T : unmanaged
        {
            var len = dst.Length;
            ref readonly var input = ref head(src);
            ref readonly var count = ref head(counts);
            ref var target = ref head(dst);

            for(var i=0; i < len; i++)
                seek(ref target,i) = gmath.srl(skip(input,i), skip(count,i));
            return dst;
        }

        /// <summary>
        /// Imagines the source operands are vectors of identical length and computes their canonical scalar product
        /// </summary>
        /// <param name="lhs">The left vector</param>
        /// <param name="rhs">The right vector</param>
        /// <typeparam name="T">The primal scalar type</typeparam>
        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.All)]
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

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.All)]
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

        [MethodImpl(Inline), SpanOp, NumericClosures(NumericKind.All)]
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
            Span<byte> dst = new byte[Checks.length(lhs,rhs)];
            for(var i=0; i<dst.Length; i++)
                dst[i] = math.avgi(lhs[i],rhs[i]);
            return dst;
        }

        public static Span<ushort> avgi(ReadOnlySpan<ushort> lhs, ReadOnlySpan<ushort> rhs)        
        {
            Span<ushort> dst = new ushort[Checks.length(lhs,rhs)];
            for(var i=0; i<dst.Length; i++)
                dst[i] = math.avgi(lhs[i],rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        static T avg_u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(avg_checked(Spans.span8u(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(avg_checked(Spans.span16u(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(avg_checked(Spans.span32u(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(avg_checked(Spans.span64u(src)));
            else
                return avg_i(src);
        }           

        [MethodImpl(Inline)]
        static T avg_i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(avg_checked(Spans.span8i(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(avg_checked(Spans.span16i(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(avg_checked(Spans.span32i(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(avg_checked(Spans.span64i(src)));
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


        [MethodImpl(Inline)]
        internal static sbyte avg_unchecked(this ReadOnlySpan<sbyte> src)
        {
            unchecked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (sbyte)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static byte avg_unchecked(this ReadOnlySpan<byte> src)
        {
            unchecked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (byte)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static short avg_unchecked(this ReadOnlySpan<short> src)
        {
            unchecked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (short)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static ushort avg_unchecked(this ReadOnlySpan<ushort> src)
        {
            unchecked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return (ushort)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static int avg_unchecked(this ReadOnlySpan<int> src)
        {
            unchecked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (int)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static uint avg_unchecked(this ReadOnlySpan<uint> src)
        {
            unchecked 
            {
                var sum = default(ulong);
                
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                
                return (uint)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static long avg_unchecked(this ReadOnlySpan<long> src)
        {
            unchecked
            {
                var sum = default(long);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/src.Length;
            }
        }

        [MethodImpl(Inline)]
        internal static ulong avg_unchecked(this ReadOnlySpan<ulong> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/(ulong)src.Length;
            }
        }

        [MethodImpl(Inline)]
        internal static sbyte avg_checked(this ReadOnlySpan<sbyte> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (sbyte)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static byte avg_checked(this ReadOnlySpan<byte> src)
        {
            checked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (byte)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static short avg_checked(this ReadOnlySpan<short> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (short)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static ushort avg_checked(this ReadOnlySpan<ushort> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return (ushort)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static int avg_checked(this ReadOnlySpan<int> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (int)(sum/(long)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static uint avg_checked(this ReadOnlySpan<uint> src)
        {
            checked 
            {
                var sum = default(ulong);
                
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                
                return (uint)(sum/(ulong)src.Length);
            }
        }

        [MethodImpl(Inline)]
        internal static long avg_checked(this ReadOnlySpan<long> src)
        {
            checked
            {
                var sum = default(long);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/src.Length;
            }
        }

        [MethodImpl(Inline)]
        internal static ulong avg_checked(this ReadOnlySpan<ulong> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/(ulong)src.Length;
            }
        } 
    }
}
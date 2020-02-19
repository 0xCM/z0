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

    public static class fspan
    {
        
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> sqrt<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                src[i] = gfp.sqrt(src[i]);
            return src;
        }
        
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(avg(span32f(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(avg(span64f(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// Computes the floating-point quotient of cells in the left and right operands,
        /// overwriting each left operand cell with the result. 
        /// Specifically, lhs[i] = lhs[i] / rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        public static Span<T> fdiv<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] = gfp.div(lhs[i], rhs[i]);
            return lhs;
        }

        /// <summary>
        /// Computes in-place the quotient of each source element in the left operand and the right operand
        /// </summary>
        /// <param name="src"></param>
        /// <param name="rhs"></param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        public static Span<T> div<T>(Span<T> src, T rhs)
            where T : unmanaged
        {
            for(var i = 0; i< src.Length; i++)
                src[i] = gfp.div(src[i], rhs);
            return src;
        }

        /// <summary>
        /// Computes the floating-point quotient of cells in the left and right operands,
        /// and writes the result in the target operand
        /// Specifically, dst[i] = lhs[i] / rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        public static Span<T> fdiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gfp.div(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline),Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale, Span<T> dst)
            where T : unmanaged
        {                        
            var count = length(src,dst);
            for(var i = 0; i< count; i++)
                dst[i] = gfp.round(src[i], scale);
            return dst;
        }

        [MethodImpl(Inline),Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> fabs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var len = length(src,dst);
            for(var i=0; i< len; i++)
                dst[i] = gfp.abs(src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            for(var i = 0; i< count; i++)
                dst[i] = gfp.mod(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<T> ceil<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var len = length(src,dst);
            for(var i =0; i<len; i++)
                dst[i] = gfp.ceil(src[i]);
            return dst;
        }

        public static Span<T> ceil<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ceil(src, alloc<T>(src.Length));

        public static Span<T> ceil<T>(Span<T> io)
            where T : unmanaged
        {
            for(var i =0; i<io.Length; i++)
                io[i] = gfp.ceil(io[i]);
            return io;
        }

        public static Span<T> floor<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var count = length(src,dst);
            for(var i =0; i<count; i++)
                dst[i] = gfp.floor(src[i]);
            return dst;
        }

        public static Span<T> floor<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => floor(src, alloc<T>(src.Length));

        public static Span<T> floor<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i =0; i<src.Length; i++)
                src[i] = gfp.floor(src[i]);
            return src;
        } 

        static float avg(ReadOnlySpan<float> src)
        {
            checked
            {
                var sum = default(double);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (float)(sum/(float)src.Length);
            }
        }

        static double avg(ReadOnlySpan<double> src)
        {
            checked
            {
                var sum = default(double);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return sum/(double)src.Length;
            }
        }
    }
}
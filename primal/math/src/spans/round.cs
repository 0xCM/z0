//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale, Span<T> dst)
            where T : unmanaged
        {            
            static Span<float> round32(ReadOnlySpan<float> src, int scale, Span<float> dst)
            {
                var len = length(src, dst);
                for(var i = 0; i< len; i++)
                    dst[i] = fmath.round(src[i], scale);
                return dst;
            }

            static Span<double> round64(ReadOnlySpan<double> src, int scale, Span<double> dst)
            {
                var len = length(src, dst);
                for(var i = 0; i< len; i++)
                    dst[i] = fmath.round(src[i], scale);
                return dst;
            }            
            
            if(typeof(T) == typeof(float))
                round32(float32(src), scale, float32(dst));
            else if(typeof(T) == typeof(double))
                round64(float64(src), scale, float64(dst));
            else
                return src.Replicate();
            return dst;
        }

        public static Span<T> round<T>(ReadOnlySpan<T> src, int scale)
            where T : unmanaged
                => round(src, scale, span<T>(src.Length));

        public static Span<T> round<T>(Span<T> io, int scale)
            where T : unmanaged
        {
         
            static void round32(Span<float> io, int scale)
            {
                for(var i = 0; i< io.Length; i++)
                    fmath.round(ref io[i], scale);
            }

            static void round64(Span<double> io, int scale)
            {
                for(var i = 0; i< io.Length; i++)
                    fmath.round(ref io[i], scale);
            }
         
            if(typeof(T) == typeof(float))
                round32(float32(io), scale);
            else if(typeof(T) == typeof(double))
                round64(float64(io), scale);
            return io;        
        }


    }

}
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
        [MethodImpl(Inline)]
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return avg_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return avg_i(src);
            else 
                return avg_f(src);
        }           

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
                gmath.avgz(ref result, skip(in reader, i));
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

        static sbyte avg(ReadOnlySpan<sbyte> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (sbyte)(sum/(long)src.Length);
            }
        }

        static byte avg(ReadOnlySpan<byte> src)
        {
            checked
            {
                var sum = default(ulong);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (byte)(sum/(ulong)src.Length);
            }
        }

        static short avg(ReadOnlySpan<short> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (short)(sum/(long)src.Length);
            }
        }

        static ushort avg(ReadOnlySpan<ushort> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return (ushort)(sum/(ulong)src.Length);
            }
        }

        static int avg(ReadOnlySpan<int> src)
        {
            checked
            {
                var sum = default(long);
                for(var i=0; i<src.Length; i++)
                    sum += src[i];
                return (int)(sum/(long)src.Length);
            }
        }

        static uint avg(ReadOnlySpan<uint> src)
        {
            checked 
            {
                var sum = default(ulong);
                
                for(var i=0; i<src.Length; i++)
                    checked{ sum += src[i];}
                
                return (uint)(sum/(ulong)src.Length);
            }
        }

        static long avg(ReadOnlySpan<long> src)
        {
            checked
            {
                var sum = default(long);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/src.Length;
            }
        }

        static ulong avg(ReadOnlySpan<ulong> src)
        {
            checked
            {
                var sum = default(ulong);

                for(var i=0; i<src.Length; i++)
                    sum += src[i];

                return sum/(ulong)src.Length;
            }
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


        public static T avg_i<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(avg(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(avg(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(avg(int32(src)));
            else 
                return generic<T>(avg(int64(src)));
        }           

        public static T avg_u<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(avg(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(avg(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(avg(uint32(src)));
            else 
                return generic<T>(avg(uint64(src)));
        }           

        public static T avg_f<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(avg(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(avg(float64(src)));
            else            
                throw unsupported<T>();
        }           

    }
}
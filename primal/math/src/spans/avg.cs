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
        public static T avg<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            static sbyte avg8i(ReadOnlySpan<sbyte> src)
            {
                checked
                {
                    var sum = default(long);
                    for(var i=0; i<src.Length; i++)
                        sum += src[i];
                    return (sbyte)(sum/(long)src.Length);
                }
            }

            static byte avg8u(ReadOnlySpan<byte> src)
            {
                checked
                {
                    var sum = default(ulong);
                    for(var i=0; i<src.Length; i++)
                        sum += src[i];
                    return (byte)(sum/(ulong)src.Length);
                }
            }

            static short avg16i(ReadOnlySpan<short> src)
            {
                checked
                {
                    var sum = default(long);
                    for(var i=0; i<src.Length; i++)
                        sum += src[i];
                    return (short)(sum/(long)src.Length);
                }
            }

            static ushort avg16u(ReadOnlySpan<ushort> src)
            {
                checked
                {
                    var sum = default(ulong);

                    for(var i=0; i<src.Length; i++)
                        sum += src[i];

                    return (ushort)(sum/(ulong)src.Length);
                }
            }
    
            static int avg32i(ReadOnlySpan<int> src)
            {
                checked
                {
                    var sum = default(long);
                    for(var i=0; i<src.Length; i++)
                        sum += src[i];
                    return (int)(sum/(long)src.Length);
                }
            }
    
            static uint avg32u(ReadOnlySpan<uint> src)
            {
                checked 
                {
                    var sum = default(ulong);
                    
                    for(var i=0; i<src.Length; i++)
                        checked{ sum += src[i];}
                    
                    return (uint)(sum/(ulong)src.Length);
                }
            }

            static long avg64i(ReadOnlySpan<long> src)
            {
                checked
                {
                    var sum = default(long);

                    for(var i=0; i<src.Length; i++)
                        sum += src[i];

                    return sum/src.Length;
                }
            }

            static ulong avg64u(ReadOnlySpan<ulong> src)
            {
                checked
                {
                    var sum = default(ulong);

                    for(var i=0; i<src.Length; i++)
                        sum += src[i];

                    return sum/(ulong)src.Length;
                }
            }

            static float avg32f(ReadOnlySpan<float> src)
            {
                checked
                {
                    var sum = default(double);
                    for(var i=0; i<src.Length; i++)
                        sum += src[i];
                    return (float)(sum/(float)src.Length);
                }
            }

            static double avg64f(ReadOnlySpan<double> src)
            {
                checked
                {
                    var sum = default(double);
                    for(var i=0; i<src.Length; i++)
                        sum += src[i];
                    return sum/(double)src.Length;
                }
            }


            if(typeof(T) == typeof(sbyte))
                return generic<T>(avg8i(int8(src)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(avg8u(uint8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(avg16i(int16(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(avg16u(uint16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(avg32i(int32(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(avg32u(uint32(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(avg64i(int64(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(avg64u(uint64(src)));
            else if(typeof(T) == typeof(float))
                return generic<T>(avg32f(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(avg64f(float64(src)));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline)]
        public static T avg<T>(Span<T> src)
            where T : unmanaged
            => avg(src.ReadOnly());


        public static Span<byte> avgz(ReadOnlySpan<byte> lhs, ReadOnlySpan<byte> rhs)        
        {
            Span<byte> dst = new byte[length(lhs,rhs)];
            for(var i=0; i<dst.Length; i++)
                dst[i] = math.avgz(lhs[i],rhs[i]);
            return dst;
        }

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

        public static ulong avgz(ReadOnlySpan<ulong> src)
        {
            if(src.IsEmpty)
                return 0;
            
            var result = src[0];
            for(var i=1; i<src.Length; i++)
                math.avgz(ref result, in src[i]);
            return result;
        }

 

    }
}
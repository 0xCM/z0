//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Creates a 256-bit vector from two 128-bit vectors    
        /// This mimics the _mm256_set_m128i intrinsic which does not appear to be available
        /// </summary>
        /// <param name="lo">The lo part</param>
        /// <param name="hi">The hi part</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> v256<T>(Vector128<T> lo, Vector128<T> hi)
            where T : unmanaged
                => vinsert(hi, vinsert(lo, default,0), 1);        

        /// <summary>
        /// Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vinsert<T>(Vector128<T> src, Vector256<T> dst, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vinsert_128u(src,dst,index);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vinsert_128i(src,dst,index);
            else 
                return vinsert_128f(src,dst,index);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinsert_128i<T>(Vector128<T> src, Vector256<T> dst, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vinsert(int8(src), int8(dst), index));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vinsert(int16(src), int16(dst), index));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vinsert(int32(src), int32(dst), index));
            else 
                return generic<T>(dinx.vinsert(int64(src), int64(dst), index));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinsert_128u<T>(Vector128<T> src, Vector256<T> dst, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vinsert(uint8(src), uint8(dst), index));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vinsert(uint16(src), uint16(dst), index));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vinsert(int64(src), int64(dst), index));
            else 
                return generic<T>(dinx.vinsert(uint64(src), uint64(dst), index));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinsert_128f<T>(Vector128<T> src, Vector256<T> dst, byte index)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vinsert(float32(src), float32(dst), index));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vinsert(float64(src), float64(dst), index));
            else
                throw unsupported<T>();
        } 
    }
}
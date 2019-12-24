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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    
    using static ginx;
    using static As;

    partial class CpuVector
    {
        /// <summary>
        /// Projects a scalar value onto each component of a 128-bit vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vbroadcast<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vbc_u(n, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vbc_i(n, src);
            else
                return vbc_f(n, src);
        }

        /// <summary>
        /// Projects a scalar value onto each component of a 256-bit vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vbroadcast<T>(N256 n, T src)
            where T : unmanaged
        {
             if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vbc_u(n, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vbc_i(n, src);
            else
                return vbc_f(n, src);
       }

        /// <summary>
        /// Projects a scalar value onto each component of a 512-bit vector
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vbroadcast<T>(N512 n, T src)
            where T : unmanaged
                => (vbroadcast(n256,src), vbroadcast(n256,src));

        /// <summary>
        /// Expands a bit-level S-pattern to a vector-level T-pattern
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source pattern</param>
        /// <param name="enabled">The value to assign to a block when the corresponding index-identified bit is enabled</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        public static Vector128<T> vbroadcast<S,T>(N128 w, S src, T enabled)
            where S : unmanaged
            where T : unmanaged
        {
            var count = Vector128<T>.Count;
            Span<T> buffer = stackalloc T[count];
            ref var dst = ref head(buffer);

            var length = math.min(count, bitsize<S>());
            for(var i=0; i< length; i++)
                seek(ref dst, i) = BitMask.testbit(src,i) ? enabled : default;
            
            return buffer.LoadVector(w);
        }

        /// <summary>
        /// Expands a bit-level S-pattern to a vector-level T-pattern
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source pattern</param>
        /// <param name="enabled">The value to assign to a block when the corresponding index-identified bit is enabled</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        public static Vector256<T> vbroadcast<S,T>(N256 w, S src, T enabled)
            where S : unmanaged
            where T : unmanaged
        {
            var count = Vector256<T>.Count;
            Span<T> buffer = stackalloc T[count];
            ref var dst = ref head(buffer);

            var length = math.min(count, bitsize<S>());
            for(var i=0; i< length; i++)
                seek(ref dst, i) = BitMask.testbit(src,i) ? enabled : default;
            
            return buffer.LoadVector(w);
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vbc_i<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vbroadcast(n128, int8(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vbroadcast(n128, int16(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vbroadcast(n128, int32(src)));
            else 
                return vgeneric<T>(dinx.vbroadcast(n128, int64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vbc_u<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vbroadcast(n128, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbroadcast(n128, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vbroadcast(n128, uint32(src)));
            else 
                return vgeneric<T>(dinx.vbroadcast(n128, uint64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vbc_f<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return  vgeneric<T>(dinxfp.vbroadcast(n128, float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vbroadcast(n128, float64(src)));
            else 
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static Vector256<T> vbc_i<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vbroadcast(n256, int8(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vbroadcast(n256, int16(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vbroadcast(n256, int32(src)));
            else 
                return  vgeneric<T>(dinx.vbroadcast(n256, int64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbc_u<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vbroadcast(n256, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbroadcast(n256, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vbroadcast(n256, uint32(src)));
            else 
                return vgeneric<T>(dinx.vbroadcast(n256, uint64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbc_f<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vbroadcast(n256, float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vbroadcast(n256, float64(src)));
            else 
                throw unsupported<T>();
        }

    }
}
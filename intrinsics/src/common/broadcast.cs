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
        public static Vector128<T> broadcast<T>(N128 n, T src)
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
        public static Vector256<T> broadcast<T>(N256 n, T src)
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
        public static Vector512<T> broadcast<T>(N512 n, T src)
            where T : unmanaged
                => (broadcast(n256,src), broadcast(n256,src));

        /// <summary>
        /// Expands a bit-level S-pattern to a vector-level T-pattern
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source pattern</param>
        /// <param name="enabled">The value to assign to a block when the corresponding index-identified bit is enabled</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        public static Vector128<T> broadcast<S,T>(N128 w, S src, T enabled)
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
        public static Vector256<T> broadcast<S,T>(N256 w, S src, T enabled)
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
                return vgeneric<T>(vbroadcast(n128, int8(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(vbroadcast(n128, int16(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(vbroadcast(n128, int32(src)));
            else 
                return vgeneric<T>(vbroadcast(n128, int64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vbc_u<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(vbroadcast(n128, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(vbroadcast(n128, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(vbroadcast(n128, uint32(src)));
            else 
                return vgeneric<T>(vbroadcast(n128, uint64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vbc_f<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return  vgeneric<T>(fpinx.vbroadcast(n128, float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vbroadcast(n128, float64(src)));
            else 
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static Vector256<T> vbc_i<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(vbroadcast(n256, int8(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(vbroadcast(n256, int16(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(vbroadcast(n256, int32(src)));
            else 
                return  vgeneric<T>(vbroadcast(n256, int64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbc_u<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(vbroadcast(n256, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(vbroadcast(n256, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(vbroadcast(n256, uint32(src)));
            else 
                return vgeneric<T>(vbroadcast(n256, uint64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbc_f<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vbroadcast(n256, float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vbroadcast(n256, float64(src)));
            else 
                throw unsupported<T>();
        }
 

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline)]
        static Vector256<byte> vbroadcast(N256 w, byte lo, byte hi)
            => vconcat(vbroadcast(n128, lo),vbroadcast(n128, hi));            

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline)]
        static Vector256<ushort> vbroadcast(N256 w, ushort lo, ushort hi)
            => vconcat(vbroadcast(n128, lo),vbroadcast(n128, hi));            

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline)]
        static Vector256<uint> vbroadcast(N256 w, uint lo, uint hi)
            => vconcat(vbroadcast(n128, lo),vbroadcast(n128, hi));            

        /// <summary>
        /// Creates a 256-bit vector where the lower 128-bit lane is filled with replicas of the lo value
        /// and the upper 128-bit lane is filled with replicas of the hi value
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="lo">The value to replicate in the lower lane</param>
        /// <param name="hi">The value to replicate in the upper lane</param>
        [MethodImpl(Inline)]
        static Vector256<ulong> vbroadcast(N256 w, ulong lo, ulong hi)
            => vconcat(vbroadcast(n128, lo),vbroadcast(n128, hi));            

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector128<sbyte> vbroadcast(N128 n, sbyte src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector128<byte> vbroadcast(N128 n, byte src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector128<short> vbroadcast(N128 n, short src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector128<ushort> vbroadcast(N128 n, ushort src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector128<int> vbroadcast(N128 n, int src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector128<uint> vbroadcast(N128 n, uint src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector128<long> vbroadcast(N128 n, long src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector128<ulong> vbroadcast(N128 n, ulong src)
            => BroadcastScalarToVector128(&src);

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector256<sbyte> vbroadcast(N256 n, sbyte src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastb_epi8 (__m128i a) VPBROADCASTB ymm, m8
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector256<byte> vbroadcast(N256 n,byte src)
            => BroadcastScalarToVector256(&src);
                        
        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector256<short> vbroadcast(N256 n, short src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        ///  __m256i _mm256_broadcastw_epi16 (__m128i a) VPBROADCASTW ymm, m16
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector256<ushort> vbroadcast(N256 n, ushort src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector256<int> vbroadcast(N256 n, int src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastd_epi32 (__m128i a) VPBROADCASTD ymm, m32
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector256<uint> vbroadcast(N256 n, uint src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        /// __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector256<long> vbroadcast(N256 n, long src)
            => BroadcastScalarToVector256(&src);

        /// <summary>
        ///  __m256i _mm256_broadcastq_epi64 (__m128i a) VPBROADCASTQ ymm, m64
        /// Creates a target vector where each component is initialized with the same value
        /// </summary>
        /// <param name="src">The value to broadcast</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        static unsafe Vector256<ulong> vbroadcast(N256 n, ulong src)
            => BroadcastScalarToVector256(&src);
  

    }
}
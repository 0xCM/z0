//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    
    using static zfunc;    
    using static AsIn;    
    using static As;

    partial class aux
    {

        [MethodImpl(Inline)]
        public static void vmaskstore_i<T>(Vector128<T> src, Vector128<byte> mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dinx.vmaskstore(int8(src), mask, ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                dinx.vmaskstore(int16(src), mask, ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.vmaskstore(int32(src), mask, ref int32(ref dst));
            else 
                dinx.vmaskstore(int64(src), mask, ref int64(ref dst));
        }

        [MethodImpl(Inline)]
        public static void vmaskstore_u<T>(Vector128<T> src, Vector128<byte> mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dinx.vmaskstore(uint8(src), mask, ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                dinx.vmaskstore(uint16(src), mask, ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.vmaskstore(uint32(src), mask, ref uint32(ref dst));
            else 
                dinx.vmaskstore(uint64(src), mask, ref uint64(ref dst));
        }

        [MethodImpl(Inline)]
        public static void vmaskstore_i<T>(Vector256<T> src, Vector256<byte> mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dinx.vmaskstore(int8(src), mask, ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                dinx.vmaskstore(int16(src), mask, ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.vmaskstore(int32(src), mask, ref int32(ref dst));
            else 
                dinx.vmaskstore(int64(src), mask, ref int64(ref dst));
        }

        [MethodImpl(Inline)]
        public static void vmaskstore_u<T>(Vector256<T> src, Vector256<byte> mask, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dinx.vmaskstore(uint8(src), mask, ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                dinx.vmaskstore(uint16(src), mask, ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.vmaskstore(uint32(src), mask, ref uint32(ref dst));
            else 
                dinx.vmaskstore(uint64(src), mask, ref uint64(ref dst));
        }


        [MethodImpl(Inline)]
        public static Vector128<T> vbc_128i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vbroadcast(n128, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vbroadcast(n128, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vbroadcast(n128, int32(src)));
            else 
                return generic<T>(dinx.vbroadcast(n128, int64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vbc_128u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vbroadcast(n128, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbroadcast(n128, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vbroadcast(n128, uint32(src)));
            else 
                return generic<T>(dinx.vbroadcast(n128, uint64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vbc_128f<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return  generic<T>(dfp.vbroadcast(n128, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vbroadcast(n128, float64(src)));
            else 
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static Vector256<T> vbc_256i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vbroadcast(n256, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vbroadcast(n256, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vbroadcast(n256, int32(src)));
            else 
                return  generic<T>(dinx.vbroadcast(n256, int64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbc_256u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vbroadcast(n256, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbroadcast(n256, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vbroadcast(n256, uint32(src)));
            else 
                return generic<T>(dinx.vbroadcast(n256, uint64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbc_256f<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vbroadcast(n256, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vbroadcast(n256, float64(src)));
            else 
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static Vector128<byte> valignr_n1<N>(Vector128<byte> x, Vector128<byte> y, N n = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N1))    
                return valignr(x,y,n1);
            else if(typeof(N) == typeof(N2))    
                return valignr(x,y,n2);
            else if(typeof(N) == typeof(N3))    
                return valignr(x,y,n3);
            else if(typeof(N) == typeof(N4))    
                return valignr(x,y,n4);
            else
                return valignr_n5(x,y,n);
        }

        [MethodImpl(Inline)]
        static Vector128<byte> valignr_n5<N>(Vector128<byte> x, Vector128<byte> y, N n = default)
            where N : unmanaged, ITypeNat
        {
        
            if(typeof(N) == typeof(N5))    
                return valignr(x,y,n5);
            else if(typeof(N) == typeof(N6))    
                return valignr(x,y,n6);
            else if(typeof(N) == typeof(N7))    
                return valignr(x,y,n7);
            else if(typeof(N) == typeof(N8))    
                return valignr(x,y,n8);
            else
                return valignr_n9(x,y,n);
        }

        [MethodImpl(Inline)]
        static Vector128<byte> valignr_n9<N>(Vector128<byte> x, Vector128<byte> y, N n = default)
            where N : unmanaged, ITypeNat
        {        
            if(typeof(N) == typeof(N9))    
                return valignr(x,y,n9);
            else if(typeof(N) == typeof(N10))    
                return valignr(x,y,n10);
            else
                throw unsupported<N>();
        }

        [MethodImpl(Inline)]
        public static Vector256<byte> valignr_n1<N>(Vector256<byte> x, Vector256<byte> y, N n = default)
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N1))    
                return valignr(x,y,n1);
            else if(typeof(N) == typeof(N2))    
                return valignr(x,y,n2);
            else if(typeof(N) == typeof(N3))    
                return valignr(x,y,n3);
            else if(typeof(N) == typeof(N4))    
                return valignr(x,y,n4);
            else
                return valignr_n5(x,y,n);
        }

        [MethodImpl(Inline)]
        static Vector256<byte> valignr_n5<N>(Vector256<byte> x, Vector256<byte> y, N n = default)
            where N : unmanaged, ITypeNat
        {
        
            if(typeof(N) == typeof(N5))    
                return valignr(x,y,n5);
            else if(typeof(N) == typeof(N6))    
                return valignr(x,y,n6);
            else if(typeof(N) == typeof(N7))    
                return valignr(x,y,n7);
            else if(typeof(N) == typeof(N8))    
                return valignr(x,y,n8);
            else
                return valignr_n9(x,y,n);
        }

        [MethodImpl(Inline)]
        static Vector256<byte> valignr_n9<N>(Vector256<byte> x, Vector256<byte> y, N n = default)
            where N : unmanaged, ITypeNat
        {        
            if(typeof(N) == typeof(N9))    
                return valignr(x,y,n9);
            else if(typeof(N) == typeof(N10))    
                return valignr(x,y,n10);
            else
                throw unsupported<N>();
        }

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 1-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N1 n)
            => AlignRight(x, y, 1);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a s-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N2 n)
            => AlignRight(x, y, 2);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 3-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N3 n)
            => AlignRight(x, y, 3);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 4-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N4 n)
            => AlignRight(x, y, 4);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 5-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N5 n)
            => AlignRight(x, y, 5);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 6-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N6 n)
            => AlignRight(x, y, 6);

        /// <summary>
        /// _m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count) PALIGNR xmm, xmm/m128, imm8 
        /// Applies a 7-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N7 n)
            => AlignRight(x, y, 7);

        /// <summary>
        /// __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count)PALIGNR xmm, xmm/m128, imm8
        /// Applies an 8-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N8 n)
            => AlignRight(x, y, 8);

        /// <summary>
        /// __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count)PALIGNR xmm, xmm/m128, imm8
        /// Applies a 9-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N9 n)
            => AlignRight(x, y, 9);

        /// <summary>
        /// __m128i _mm_alignr_epi8 (__m128i a, __m128i b, int count)PALIGNR xmm, xmm/m128, imm8
        /// Applies a 10-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector128<byte> valignr(Vector128<byte> x, Vector128<byte> y, N10 n)
            => AlignRight(x, y, 10);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count) VPALIGNR ymm,ymm, ymm/m256, imm8 
        /// </summary>
        /// <param name="x">The x source vector</param>
        /// <param name="y">The y source vector</param>
        /// <param name="offset">The number of *bytes* to shift ywards</param>
        /// <remarks>
        /// Intel's description:
        /// Performs an alignment operation by concatenating two blocks of 16-byte data 
        /// from the first and second source vectors into an intermediate 32-byte composite, 
        /// shifting the composite at byte granularity to the right by a constant immediate 
        /// specified by mask, and extracting the right-aligned 16-byte result into the 
        /// destination vector. The immediate value is considered unsigned.
        /// tmp1[255:0] := ((x[127:0] << 128) OR x[127:0]) >> (offset[7:0]*8)
        /// dst[127:0] := tmp1[127:0]
        /// tmp2[255:0] := ((x[255:128] << 128) OR x[255:128]) >> (offset[7:0]*8)
        /// dst[255:127] := tmp2[127:0]
        /// </remarks>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N0 n)
            => AlignRight(x, y, 0);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 1-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N1 n)
            => AlignRight(x, y, 1);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 2-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N2 n)
            => AlignRight(x, y, 2);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 3-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N3 n)
            => AlignRight(x, y, 3);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 4-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N4 n)
            => AlignRight(x, y, 4);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 5-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N5 n)
            => AlignRight(x, y, 5);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 6-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N6 n)
            => AlignRight(x, y, 6);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 7-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N7 n)
            => AlignRight(x, y, 7);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies an 8-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N8 n)
            => AlignRight(x, y, 8);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 9-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N9 n)
            => AlignRight(x, y, 9);

        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 10-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N10 n)
            => AlignRight(x, y, 10);
 
        /// <summary>
        /// __m256i _mm256_alignr_epi8 (__m256i a, __m256i b, const int count)VPALIGNR ymm, ymm, ymm/m256, imm8
        /// Applies a 10-byte right alignment shift
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="n">The shift amount selector</param>
        [MethodImpl(Inline)]
        static Vector256<byte> valignr(Vector256<byte> x, Vector256<byte> y, N11 n)
            => AlignRight(x, y, 11);

        [MethodImpl(Inline)]
        public static Vector128<T> vhi_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vhi(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vhi(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vhi(int32(src)));
            else
                return generic<T>(dinx.vhi(int64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vhi_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vhi(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vhi(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vhi(uint32(src)));
            else 
                return generic<T>(dinx.vhi(uint64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vhi_f<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vhi(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vhi(float64(src)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector128<T> vlo_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vlo(int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vlo(int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vlo(int32(src)));
            else
                return generic<T>(dinx.vlo(int64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vlo_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vlo(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vlo(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vlo(uint32(src)));
            else 
                return generic<T>(dinx.vlo(uint64(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vlo_f<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vlo(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vlo(float64(src)));
            else 
                throw unsupported<T>();
        }
 

         [MethodImpl(Inline)]
        public static unsafe void vloadu_u<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dst = generic<T>(LoadDquVector256((byte*)pSrc));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(LoadDquVector256((ushort*)pSrc));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(LoadDquVector256((uint*)pSrc));
            else 
                dst = generic<T>(LoadDquVector256((ulong*)pSrc));

        }

        [MethodImpl(Inline)]
        public static unsafe void vloadu_i<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(LoadDquVector256((sbyte*)pSrc));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(LoadDquVector256((short*)pSrc));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(LoadDquVector256((int*)pSrc));
            else 
                dst = generic<T>(LoadDquVector256((long*)pSrc));

        }

        [MethodImpl(Inline)]
        public static unsafe void vloadu_f<T>(T* pSrc, out Vector256<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                dst = generic<T>(LoadVector256((float*)pSrc));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(LoadVector256((double*)pSrc));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static unsafe void vloadu_u<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dst = generic<T>(LoadDquVector128((byte*)pSrc));
            else if(typeof(T) == typeof(ushort))
                dst = generic<T>(LoadDquVector128((ushort*)pSrc));
            else if(typeof(T) == typeof(uint))
                dst = generic<T>(LoadDquVector128((uint*)pSrc));
            else 
                dst = generic<T>(LoadDquVector128((ulong*)pSrc));

        }

        [MethodImpl(Inline)]
        public static unsafe void vloadu_i<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dst = generic<T>(LoadDquVector128((sbyte*)pSrc));
            else if(typeof(T) == typeof(short))
                dst = generic<T>(LoadDquVector128((short*)pSrc));
            else if(typeof(T) == typeof(int))
                dst = generic<T>(LoadDquVector128((int*)pSrc));
            else 
                dst = generic<T>(LoadDquVector128((long*)pSrc));

        }

        [MethodImpl(Inline)]
        public static unsafe void vloadu_f<T>(T* pSrc, out Vector128<T> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                dst = generic<T>(LoadVector128((float*)pSrc));
            else if(typeof(T) == typeof(double))
                dst = generic<T>(LoadVector128((double*)pSrc));
            else 
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static Vector128<T> vload_u<T>(N128 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vload(n, in uint8(in src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vload(n, in uint16(in src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vload(n, in uint32(in src), offset));
            else
                return generic<T>(dinx.vload(n, in uint64(in src), offset));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vload_i<T>(N128 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vload(n, in int8(in src), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vload(n, in int16(in src), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vload(n, in int32(in src), offset));
            else
                return generic<T>(dinx.vload(n, in int64(in src), offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vload_u<T>(N256 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vload(n, in uint8(in src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vload(n, in uint16(in src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vload(n, in uint32(in src), offset));
            else
                return generic<T>(dinx.vload(n, in uint64(in src), offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vload_i<T>(N256 n, in T src, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vload(n, in int8(in src), offset));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vload(n, in int16(in src), offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vload(n, in int32(in src), offset));
            else
                return generic<T>(dinx.vload(n, in int64(in src), offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vinsert_i<T>(Vector128<T> src, Vector256<T> dst, byte index)        
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
        public static Vector256<T> vinsert_u<T>(Vector128<T> src, Vector256<T> dst, byte index)        
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
        public static Vector256<T> vinsert_f<T>(Vector128<T> src, Vector256<T> dst, byte index)        
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
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
        
    using static zfunc;

    /// <summary>
    /// Literals that define a new 256-bit vector by selecting 128-bits lanes from two 256-bit source vectors
    /// via a perm2x128 intrinsic function
    /// </summary>
    public enum Perm2x128 : byte
    {
        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [1, 3, 0, 2]
        /// </summary>
        AC = 0b00000010,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [5, 7, 0, 2]
        /// </summary>
        AD = 0b00000011,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [1, 3, 4, 6]
        /// </summary>
        BC = 0b00010010,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [5, 7, 4, 6]
        /// </summary>
        BD = 0b00010011,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [0, 2, 1, 3]
        /// </summary>
        CA = 0b00100000,
        
        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [0, 2, 5, 7]
        /// </summary>
        DA = 0b00110000,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [4, 6, 1, 3]
        /// </summary>
        CB = 0b00100001,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [4, 6, 5, 7]
        /// </summary>
        DB = 0b00110001,

    }

    partial class dinx    
    {        

        /// <summary>
        /// __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> vperm2x128(in Vec256<sbyte> x, in Vec256<sbyte> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vperm2x128(in Vec256<byte> x, in Vec256<byte> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vec256<short> vperm2x128(in Vec256<short> x, in Vec256<short> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vperm2x128(in Vec256<ushort> x, in Vec256<ushort> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vec256<int> vperm2x128(in Vec256<int> x, in Vec256<int> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vperm2x128(in Vec256<uint> x, in Vec256<uint> y, Perm2x128 spec)
            => Permute2x128(x,y,(byte)spec);

        /// <summary>
        /// __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vec256<long> vperm2x128(in Vec256<long> x, in Vec256<long> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256i _mm256_permute2x128_si256 (__m256i a, __m256i b, const int imm8) VPERM2I128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vperm2x128(in Vec256<ulong> x, in Vec256<ulong> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        [MethodImpl(Inline)]
        public static Vec256<float> vperm2x128(in Vec256<float> x, in Vec256<float> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

        /// <summary>
        /// __m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="spec"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vec256<double> vperm2x128(in Vec256<double> x, in Vec256<double> y, Perm2x128 spec)
            => Permute2x128(x.ymm, y.ymm, (byte)spec);

 

    }

}
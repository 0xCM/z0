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

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    partial class dinx
    {
        /// <summary>
        /// _m128i _mm_lddqu_si128 (__m128i const* mem_addr)LDDQU xmm, m128
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> lddqu128(in byte src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> lddqu128(in sbyte src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> lddqu128(in short src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> lddqu128(in ushort src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> lddqu128(in int src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> lddqu128(in uint src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> lddqu128(in long src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> lddqu128(in ulong src)
            => LoadDquVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> lddqu256(in byte src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> lddqu256(in sbyte src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> lddqu256(in short src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> lddqu256(in ushort src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> lddqu256(in int src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> lddqu256(in uint src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> lddqu256(in long src)
            => LoadDquVector256(constptr(in src));

        /// <summary>
        /// __m256i _mm256_lddqu_si256 (__m256i const * mem_addr)VLDDQU ymm, m256
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> lddqu256(in ulong src)
            => LoadDquVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<byte> load128(in byte src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<sbyte> load128(in sbyte src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<short> load128(in short src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<ushort> load128(in ushort src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<int> load128(in int src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<uint> load128(in uint src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec128<long> load128(in long src)
            => LoadAlignedVector128(constptr(in src));
 
        [MethodImpl(Inline)]
        public static unsafe Vec128<ulong> load128(in ulong src)
            => LoadAlignedVector128(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<byte> load256(in byte src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<sbyte> load256(in sbyte src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<short> load256(in short src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<ushort> load256(in ushort src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<int> load256(in int src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<uint> load256(in uint src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static unsafe Vec256<long> load256(in long src)
            => LoadAlignedVector256(constptr(in src));
 
        [MethodImpl(Inline)]
        public static unsafe Vec256<ulong> load256(in ulong src)
            => LoadAlignedVector256(constptr(in src));

        [MethodImpl(Inline)]
        public static void load256(in byte ymem0, out Vec256<byte> ymm0)
        {
            ymm0 = dinx.load256(ymem0);
        }


        [MethodImpl(Inline)]
        public static void load256(in int ymem0, out Vec256<int> ymm0)
        {
            ymm0 = dinx.load256(ymem0);
        }

        [MethodImpl(Inline)]
        public static void load256(in byte src1, in byte src2, out Vec256<byte> dst1, out Vec256<byte> dst2)
        {
            load256(src1, out dst1);
            load256(src2, out dst2);
        }

        [MethodImpl(Inline)]
        public static void load256(in byte src1, in byte src2, in byte src3, in byte src4, 
            out Vec256<byte> dst1, out Vec256<byte> dst2, out Vec256<byte> dst3, out Vec256<byte> dst4)
        {
            load256(in src1, in src2, out dst1, out dst2);
            load256(in src3, in src4, out dst3, out dst4);
        }

        [MethodImpl(Inline)]
        public static void load256(in int src1, in int src2, out Vec256<int> dst1, out Vec256<int> dst2)
        {
            dst1 = dinx.load256(src1);
            dst2 = dinx.load256(src2);
        }

    }
}
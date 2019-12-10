//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static zfunc;
    
    partial class Bits
    {               
        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte blsmsk(byte src)
            => (byte)GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort blsmsk(ushort src)
            => (ushort)GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint blsmsk(uint src)
            => GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned __int64 _blsmsk_u64 (unsigned __int64 a) BLSMSK reg, reg/m6
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong blsmsk(ulong src)
            => GetMaskUpToLowestSetBit(src);
          
        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong lomask<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatMath.pow2m1<N>();

        /// <summary>
        /// Reurns a sequence of n enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong lomask(int n)
            => blsmsk(Pow2.pow(n));

        [MethodImpl(Inline)]
        public static ulong himask(int n)
        {
            int count = 64 - n;
            var lo = Bits.lomask(count - 1);
            var shift = 64 - count;
            return lo << shift;
        }
                 
        /// <summary>
        /// Enables a bit in the target identified its pow2 exponent
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong mask(int exp0)
            => 1ul << exp0;

        /// <summary>
        /// Enables 2 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong mask(int exp0, int exp1)
            => 1ul << exp0 | 1ul << exp1; 

        /// <summary>
        /// Enables 3 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong mask(int exp0, int exp1, int exp2)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2; 

        /// <summary>
        /// Enables 4 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong mask(int exp0, int exp1, int exp2, int exp3)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3; 

        /// <summary>
        /// Enables 5 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        /// <param name="exp4">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong mask(int exp0, int exp1, int exp2, int exp3, int exp4)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3 | 
               1ul << exp4;

        /// <summary>
        /// Enables 6 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        /// <param name="exp4">An integer within the range [0,63]</param>
        /// <param name="exp5">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong mask(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3 | 
               1ul << exp4 | 1ul << exp5;

        /// <summary>
        /// Enables 7 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        /// <param name="exp4">An integer within the range [0,63]</param>
        /// <param name="exp5">An integer within the range [0,63]</param>
        /// <param name="exp6">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong mask(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3 | 
               1ul << exp4 | 1ul << exp5 | 1ul << exp6;

        /// <summary>
        /// Enables 8 bits in the target identified by pow2 exponents
        /// </summary>
        /// <param name="dst">The mask reference</param>
        /// <param name="exp0">An integer within the range [0,63]</param>
        /// <param name="exp1">An integer within the range [0,63]</param>
        /// <param name="exp2">An integer within the range [0,63]</param>
        /// <param name="exp3">An integer within the range [0,63]</param>
        /// <param name="exp4">An integer within the range [0,63]</param>
        /// <param name="exp5">An integer within the range [0,63]</param>
        /// <param name="exp6">An integer within the range [0,63]</param>
        /// <param name="exp7">An integer within the range [0,63]</param>
        [MethodImpl(Inline)]
        public static ulong mask(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
            => 1ul << exp0 | 1ul << exp1 | 1ul << exp2 | 1ul << exp3 | 
               1ul << exp4 | 1ul << exp5 | 1ul << exp6 | 1ul << exp7;
    }
}
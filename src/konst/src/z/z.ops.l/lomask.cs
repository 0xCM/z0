//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;


    using static Konst;

    partial struct z
    {                
        /// <summary>
        /// Produces a sequence of n enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline),Op]
        public static ulong lo64(int n)
            => lomask(Pow2.pow(n));

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static byte lomask(byte src)
            => (byte)GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort lomask(ushort src)
            => (ushort)GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint lomask(uint src)
            => GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned __int64 _blsmsk_u64 (unsigned __int64 a) BLSMSK reg, reg/m6
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong lomask(ulong src)
            => GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the 
        /// lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static T lomask<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(lomask(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(lomask(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(lomask(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(lomask(uint64(src)));
            else            
                throw no<T>();
        }           
    }
}
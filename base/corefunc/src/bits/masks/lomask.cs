//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static zfunc;
    using static As;

    using static BitMasks;

    public static partial class BitMask
    {           
        /// <summary>
        /// Reurns a sequence of n enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong lomask64(int n)
            => blsmsk(Pow2.pow(n));

        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        [MethodImpl(Inline)]
        public static T lomask<T>(int n)
            where T : unmanaged
                => convert<ulong,T>(lomask64(n));

        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static ulong lomask<N>(N n = default)
            where N : unmanaged, ITypeNat
                => lomask64(n);

        /// <summary>
        /// Defines a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        public static T lomask<N,T>(N n = default, T t = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => convert<ulong,T>(lomask64(n));

        /// <summary>
        /// Returns a sequence of enabled hi bits from a specified index through the last bit
        /// </summary>
        /// <param name="n">The position at which to start</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T himask<T>(int n)
            where T : unmanaged
                => convert<ulong,T>(lomask64(bitsize<T>() - n - 1) << bitsize<T>() - n);

        /// <summary>
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the 
        /// lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static T blsmsk<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(blsmsk(uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(blsmsk(uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(blsmsk(uint32(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(blsmsk(uint64(src)));
            else            
                throw unsupported<T>();
        }           

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        static byte blsmsk(byte src)
            => (byte)GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        static ushort blsmsk(ushort src)
            => (ushort)GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned int _blsmsk_u32 (unsigned int a) BLSMSK reg, reg/m32
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        static uint blsmsk(uint src)
            => GetMaskUpToLowestSetBit(src);

        /// <summary>
        /// unsigned __int64 _blsmsk_u64 (unsigned __int64 a) BLSMSK reg, reg/m6
        /// Logically equivalent to the composite operation (src-1) ^ src that enables the lower bits of the source up to and including the least set bit
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        static ulong blsmsk(ulong src)
            => GetMaskUpToLowestSetBit(src);


        /// <summary>
        /// Reurns a sequence of N enabled bits, starting from index 0 and extending to index n - 1
        /// </summary>
        /// <typeparam name="N">The enabled bit count type</typeparam>
        [MethodImpl(Inline)]
        static ulong lomask64<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatMath.pow2m1<N>();

    }
}
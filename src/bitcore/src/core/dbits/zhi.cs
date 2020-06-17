//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;

    using static Konst;

    partial class Bits
    {                
        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), ZHi]
        public static byte zhi(byte src, int index)
            => (byte)ZeroHighBits((uint)src, (uint)index);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), ZHi]
        public static ushort zhi(ushort src, int index)
            => (ushort)ZeroHighBits((uint)src, (uint)index);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), ZHi]
        public static uint zhi(uint src, int index)
            => ZeroHighBits(src, (uint)index);

        /// <summary>
        /// unsigned __int64 _bzhi_u64 (unsigned __int64 a, unsigned int index) BZHI r64a,reg/m32, r64b 
        /// Disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin disabling bits</param>
        [MethodImpl(Inline), ZHi]
        public static ulong zhi(ulong src, int index)
            => ZeroHighBits(src, (uint)index);
    }
}
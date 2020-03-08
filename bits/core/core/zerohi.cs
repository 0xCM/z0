//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;

    using static Root;

    partial class Bits
    {                
        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static byte zerohi(byte src, int index)
            => (byte)ZeroHighBits((uint)src, (uint)index);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static ushort zerohi(ushort src, int index)
            => (ushort)ZeroHighBits((uint)src, (uint)index);

        /// <summary>
        /// unsigned int _bzhi_u32 (unsigned int a, unsigned int index) BZHI r32a, reg/m32, r32b
        /// Replicates the source bits to the target and disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static uint zerohi(uint src, int index)
            => ZeroHighBits(src, (uint)index);

        /// <summary>
        /// unsigned __int64 _bzhi_u64 (unsigned __int64 a, unsigned int index) BZHI r64a,reg/m32, r64b 
        /// Disables the high target bits starting at a specified index.
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="index">The index at which to begin disabling bits</param>
        [MethodImpl(Inline), Op]
        public static ulong zerohi(ulong src, int index)
            => ZeroHighBits(src, (uint)index);
    }
}
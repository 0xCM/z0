//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;

    using static Root;

    partial class Bits
    {                
        /// <summary>
        /// Deposits contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), Op]
        public static byte scatter(byte src, byte mask)  
            => (byte)ParallelBitDeposit(src, mask); 

        /// <summary>
        /// Deposits contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), Op]
        public static ushort scatter(ushort src, ushort mask)          
            => (ushort)ParallelBitDeposit(src,mask); 

        /// <summary>
        /// unsigned int _pdep_u32 (unsigned int a, unsigned int mask) PDEP r32a, r32b, reg/m32
        /// Deposits contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), Op]
        public static uint scatter(uint src, uint mask)  
            => ParallelBitDeposit(src, mask); 

        /// <summary>
        /// unsigned __int64 _pdep_u64 (unsigned __int64 a, unsigned __int64 mask) PDEP r64a, r64b, reg/m64
        /// Deposits contiguous low bits from the source across a target according to a mask
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline), Op]
        public static ulong scatter(ulong src, ulong mask)        
            => X64.ParallelBitDeposit(src,mask);

    }

}
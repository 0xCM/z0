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

    using static Konst;

    partial class Bits
    {                
        /// <summary>
        /// unsigned int _blsi_u32 (unsigned int a)BLSI reg, reg/m32
        /// Extracts the least set bit and is logically equivalent to the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static byte xlsb(byte src)
            => (byte)ExtractLowestSetBit(src);
 
        /// <summary>
        /// unsigned int _blsi_u32 (unsigned int a)BLSI reg, reg/m32
        /// Extracts the least set bit and is logically equivalent to the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static ushort xlsb(ushort src)
            => (ushort)ExtractLowestSetBit(src);
 
        /// <summary>
        /// unsigned int _blsi_u32 (unsigned int a)BLSI reg, reg/m32
        /// Extracts the least set bit and is logically equivalent to the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static uint xlsb(uint src)
            => ExtractLowestSetBit(src);

        /// <summary>
        /// unsigned __int64 _blsi_u64 (unsigned __int64 a)BLSI reg, reg/m64
        /// Extracts the least set bit and is logically equivalent to the composite operation (-src) & src
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static ulong xlsb(ulong src)
            => ExtractLowestSetBit(src);
    }
}
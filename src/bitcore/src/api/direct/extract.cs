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
    using static Part;

    partial class Bits
    {
        /// <summary>
        /// Extracts a specified set of bits from a source
        /// unsigned int _bextr2_u32 (unsigned int a, unsigned int control) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="spec">The selection specifier</param>
        [MethodImpl(Inline), Op]
        public static sbyte extract(sbyte src, BitExtractSpec spec)
            => (sbyte)BitFieldExtract((uint)src, spec);

        /// <summary>
        /// Extracts a specified set of bits from a source
        /// unsigned int _bextr2_u32 (unsigned int a, unsigned int control) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="spec">The selection specifier</param>
        [MethodImpl(Inline), Op]
        public static byte extract(byte src, BitExtractSpec spec)
            => (byte)BitFieldExtract(src, spec);

        /// <summary>
        /// Extracts a specified set of bits from a source
        /// unsigned int _bextr2_u32 (unsigned int a, unsigned int control) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="spec">The selection specifier</param>
        [MethodImpl(Inline), Op]
        public static short extract(short src, BitExtractSpec spec)
            => (short)BitFieldExtract((uint)src, spec);

        /// <summary>
        /// Extracts a specified set of bits from a source
        /// unsigned int _bextr2_u32 (unsigned int a, unsigned int control) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="spec">The selection specifier</param>
        [MethodImpl(Inline), Op]
        public static ushort extract(ushort src, BitExtractSpec spec)
            => (ushort)BitFieldExtract(src, spec);

        /// <summary>
        /// Extracts a specified set of bits from a source
        /// unsigned int _bextr2_u32 (unsigned int a, unsigned int control) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="spec">The selection specifier</param>
        [MethodImpl(Inline), Op]
        public static int extract(int src, BitExtractSpec spec)
            => (int)BitFieldExtract((uint)src, spec);

        /// <summary>
        /// Extracts a specified set of bits from a source
        /// unsigned int _bextr2_u32 (unsigned int a, unsigned int control) BEXTR r32a, reg/m32, r32b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="spec">The selection specifier</param>
        [MethodImpl(Inline), Op]
        public static uint extract(uint src, BitExtractSpec spec)
            => BitFieldExtract(src, spec);

        /// <summary>
        /// Extracts a specified set of bits from a source
        /// unsigned __int64 _bextr2_u64 (unsigned __int64 a, unsigned __int64 control) BEXTR r64a, reg/m64, r64b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="spec">The selection specifier</param>
        [MethodImpl(Inline), Op]
        public static long extract(long src, BitExtractSpec spec)
            => (long)BitFieldExtract((ulong)src, spec);

        /// <summary>
        /// Extracts a contiguous sequence of bits from the source
        /// unsigned __int64 _bextr2_u64 (unsigned __int64 a, unsigned __int64 control) BEXTR r64a, reg/m64, r64b
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="spec">The selection specifier</param>
        [MethodImpl(Inline), Op]
        public static ulong extract(ulong src, BitExtractSpec spec)
            => BitFieldExtract(src, spec);
    }
}
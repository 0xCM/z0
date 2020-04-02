//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Core;

    partial class BitPack
    {
        /// <summary>
        /// Packs 16 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7]</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ushort pack8<T>(Vector128<T> src, byte index)
            where T : unmanaged
                => gvec.vtakemask(src,index);

        /// <summary>
        /// Packs 32 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7]</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static uint pack8<T>(Vector256<T> src, byte index)
            where T : unmanaged
                => gvec.vtakemask(src,index);

        /// <summary>
        /// Packs 16 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ushort packmsb8<T>(Vector128<T> src)
            where T : unmanaged
                => gvec.vtakemask(src);

        /// <summary>
        /// Packs 32 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ulong packmsb8<T>(Vector256<T> src)
            where T : unmanaged
                => gvec.vtakemask(src);

        /// <summary>
        /// Packs 16 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static ushort packlsb8<T>(Vector128<T> src)
            where T : unmanaged
                => pack8(src,0);

        /// <summary>
        /// Packs 32 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static uint packlsb8<T>(Vector256<T> src)
            where T : unmanaged
                => pack8(src,0);
    }
}
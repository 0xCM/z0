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
    
    using static Seed;

    partial class BitPack
    {
        /// <summary>
        /// Packs 16 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7]</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort packindex<T>(Vector128<T> src, byte index)
            where T : unmanaged
                => gvec.vtakemask(src,index);

        /// <summary>
        /// Packs 32 1-bit values taken from each source byte at a specified index
        /// </summary>
        /// <param name="src">The bit soure</param>
        /// <param name="index">The byte-relative index from which the bit will be extracted, an integer in the range [0,7]</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint packindex<T>(Vector256<T> src, byte index)
            where T : unmanaged
                => gvec.vtakemask(src,index);
    }
}
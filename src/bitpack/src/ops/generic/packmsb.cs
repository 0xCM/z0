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
    
    using static Konst;

    partial class BitPack
    {
        /// <summary>
        /// Packs 16 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort packmsb<T>(Vector128<T> src, N8 mod)
            where T : unmanaged
                => gvec.vtakemask(src);

        /// <summary>
        /// Packs 32 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong packmsb<T>(Vector256<T> src, N8 mod)
            where T : unmanaged
                => gvec.vtakemask(src);
    }
}
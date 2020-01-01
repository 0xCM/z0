//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static AsIn;
    using static dinx;

    partial class BitPack
    {

        /// <summary>
        /// Packs 16 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort msbpack(Vector128<byte> src)
            => dinx.vtakemask(src);

        /// <summary>
        /// Packs 32 1-bit values taken from the most significant bit of each source byte
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong msbpack(Vector256<byte> src)
            => dinx.vtakemask(src);



    }

}
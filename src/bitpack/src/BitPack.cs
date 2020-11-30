//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BitMasks.Literals;
    using static BitMasks;

    [ApiHost("api")]
    public partial class BitPack
    {
        const NumericKind Closure = Konst.UnsignedInts;

        /// <summary>
        /// Packs 8 1-bit values taken from the least significant bit of each source byte
        /// </summary>
        [MethodImpl(Inline)]
        static byte pack8(ulong src)
            => (byte)gather(src, Lsb64x8x1);
    }
}
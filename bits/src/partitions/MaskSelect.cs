//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;

    using static zfunc;
    using static BitParts;

    partial class BitParts
    {
        /// <summary>
        /// Selects the mask-identified bits from a source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection spec</param>
        [MethodImpl(Inline)]
        public static byte select(byte src, BitMask8 spec)
            => Bits.gather(src, (byte)spec);

        /// <summary>
        /// Selects the mask-identified bits from a source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection spec</param>
        [MethodImpl(Inline)]
        public static ushort select(ushort src, BitMask16 spec)
            => Bits.gather(src, (ushort)spec);

        /// <summary>
        /// Selects the mask-identified bits from a source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection spec</param>
        [MethodImpl(Inline)]
        public static uint select(uint src, BitMask32 spec)
            => Bits.gather(src, (uint)spec);

        /// <summary>
        /// Selects the mask-identified bits from a source
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="spec">The bit selection spec</param>
        [MethodImpl(Inline)]
        public static ulong select(ulong src, BitMask64 spec)
            => Bits.gather(src, (ulong)spec);

    }
}
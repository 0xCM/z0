//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static PrimalBits;

    partial struct ClrPrimitives
    {
        [MethodImpl(Inline), Op]
        public static ref readonly SegMask filter(Field i)
            => ref skip(Masks, (byte)i);

        [MethodImpl(Inline), Op]
        public static PrimitiveKind filter(byte src, SegMask mask)
            => (PrimitiveKind)(src & (byte)mask);

        /// <summary>
        /// Isolates an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline), Op]
        public static PrimitiveKind filter(PrimitiveKind src, Field i)
            => filter((byte)src, filter(i));
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;
    using static PrimalBits;

    partial struct ClrPrimitives
    {
        [MethodImpl(Inline), Op]
        public static ref readonly SegMask filter(Field i)
            => ref skip(Masks, (byte)i);

        [MethodImpl(Inline), Op]
        public static PrimalKind filter(byte src, SegMask mask)
            => (PrimalKind)(src & (byte)mask);

        /// <summary>
        /// Isolates an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind filter(PrimalKind src, Field i)
            => filter((byte)src, filter(i));
    }
}
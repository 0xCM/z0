//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static PrimalBitFieldSpec;

    partial struct Primitive
    {
        /// <summary>
        /// Isolates an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline), Op]
        public static PrimalKind filter(PrimalKindBitField src, SegId i)
            => filter(src.Content, filter(i));

        [MethodImpl(Inline), Op]
        public static ref readonly SegMask filter(SegId i)
            => ref skip(Masks, (byte)i);

        [MethodImpl(Inline), Op]
        public static PrimalKind filter(byte src, SegMask mask)
            => (PrimalKind)(src & (byte)mask);       
    }
}
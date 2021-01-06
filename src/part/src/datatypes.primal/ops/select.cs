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

    partial struct SystemPrimitives
    {
        /// <summary>
        /// Gets the value of an identified bitfield segment
        /// </summary>
        /// <param name="src">The source bitfield</param>
        /// <param name="i">The segment identifier</param>
        [MethodImpl(Inline), Op]
        public static byte select(PrimalKind src, Field i)
            => (byte)view(filter(src,i), index(i));

        [MethodImpl(Inline), Op]
        static ref readonly SegPos index(Field i)
            => ref skip(Positions, (byte)i);

        [MethodImpl(Inline), Op]
        static PrimalKind view(PrimalKind src, SegPos offset)
            => (PrimalKind)((byte)src >> (byte)offset);
    }
}
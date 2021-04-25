//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static PrimalBits;

    partial struct Clr
    {
        /// <summary>
        /// Computes the bit-width of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline), Op]
        public static TypeWidth width(ClrPrimalKind f)
            => (TypeWidth)Pow2.pow(ClrPrimitives.select(f, Field.Width));
    }
}
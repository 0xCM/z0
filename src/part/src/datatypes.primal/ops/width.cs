//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static PrimalBits;

    partial struct ClrPrimitives
    {
        /// <summary>
        /// Computes the bit-width of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline), Op]
        public static TypeWidth width(PrimalKind f)
            => (TypeWidth)Pow2.pow(select(f, Field.Width));
    }
}
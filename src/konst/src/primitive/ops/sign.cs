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
        /// Gets the numeric sign, if any, of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline), Op]
        public static SignKind sign(PrimalKindBitField f)
            => (SignKind)select(f, SegId.Sign);
    }
}
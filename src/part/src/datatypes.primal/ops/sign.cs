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

    partial struct SystemPrimitives
    {
        /// <summary>
        /// Determines the numeric sign, if any, of the represented primitive
        /// </summary>
        /// <param name="f">The literal's bitfield</param>
        [MethodImpl(Inline)]
        public static SignKind sign(PrimalKind f)
            => (SignKind)select(f, Field.Sign);
    }
}
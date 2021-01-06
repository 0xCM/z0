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
        [MethodImpl(Inline), Op]
        public static TypeCode code(PrimalKind f)
            => (TypeCode)select(f, Field.KindId);
    }
}
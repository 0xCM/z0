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
        [MethodImpl(Inline), Op]
        public static PrimalTypeCode id(ClrPrimalKind f)
            => (PrimalTypeCode)select(f, Field.KindId);
    }
}
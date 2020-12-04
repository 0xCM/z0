//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static ClrPrimitiveRecord describe(PrimalKind src)
            => new ClrPrimitiveRecord(src, ClrPrimitives.width(src), ClrPrimitives.sign(src), (PrimalTypeCode)ClrPrimitives.code(src));
    }
}
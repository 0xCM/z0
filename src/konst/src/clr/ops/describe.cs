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

    partial struct Clr
    {
        [MethodImpl(Inline), Op]
        public static ClrPrimitiveInfo describe(ClrPrimalKind src)
            => new ClrPrimitiveInfo(src, ClrPrimitives.width(src), ClrPrimitives.sign(src), (PrimalCode)ClrPrimitives.code(src));
    }
}
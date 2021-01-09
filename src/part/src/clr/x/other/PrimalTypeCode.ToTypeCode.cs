//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static TypeCode ToTypeCode(this PrimalTypeCode src)
            => (TypeCode)src;
    }
}
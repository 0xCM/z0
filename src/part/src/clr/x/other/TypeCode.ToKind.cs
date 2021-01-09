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
        [MethodImpl(Inline)]
        public static PrimalTypeCode ToKind(this TypeCode src)
            => (PrimalTypeCode)src;
    }
}
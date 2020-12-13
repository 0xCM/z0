//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XClrQuery
    {
        [MethodImpl(Inline)]
        public static PrimalTypeCode ToKind(this TypeCode src)
            => (PrimalTypeCode)src;

        [MethodImpl(Inline)]
        public static TypeCode ToTypeCode(this PrimalTypeCode src)
            => (TypeCode)src;

        [MethodImpl(Inline)]
        public static string Format(this PrimalTypeCode src)
            => src.ToString();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XApiIdentity
    {
        [MethodImpl(Inline), Op]
        public static NumericWidth NumericWidth(this Type t)
            => Widths.numeric(t);
    }
}
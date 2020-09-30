//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using static Konst;

    [ApiHost(ApiNames.XQuery)]
    public partial class XQuery
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        static T cast<T>(object src)
            => (T)src;
    }
}
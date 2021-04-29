//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    partial class MSvcHosts
    {
        [Closures(AllNumeric), Parse]
        public readonly struct Parse<T> : ITextParserFunc<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public readonly T Invoke(string a)
                => Numeric.parser<T>().Parse(a).ValueOrDefault();
        }
    }
}
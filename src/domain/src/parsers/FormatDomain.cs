//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly partial struct FormatDomain
    {
        [MethodImpl(Inline)]
        public static string format<A,B>(string pattern, A a, B b)
            => string.Format(pattern, a, b);
    }
}
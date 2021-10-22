//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        partial struct Meta
        {
            [MethodImpl(Inline), Op, Closures(Closure)]
            public static Enum<V> @enum<V>(Label name, Literal<V>[] src)
                => new Enum<V>(name, src);
        }
    }
}
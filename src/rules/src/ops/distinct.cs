//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [Op]
        public static Distinct distinct()
            => default;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Distinct<T> distinct<T>()
            where T : IEquatable<T>
                => default;
    }
}
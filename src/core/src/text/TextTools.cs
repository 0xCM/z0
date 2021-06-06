//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Collections.Generic;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct TextTools
    {
        const NumericKind Closure = UInt64k;

        [MethodImpl(Inline), Op]
        public static StringAddress address(string src)
            => new StringAddress(src?.Length == 0 ? core.address(StringAddress.Empty) : core.address(string.Intern(src)));

        [MethodImpl(Inline), Op]
        public static StringAddress resource(string src)
            => new StringAddress(core.address(src));
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static StringAddress intern(string src)
            => new StringAddress(src?.Length == 0 ? core.address(StringAddress.EmptyMarker) : core.address(string.Intern(src)));
    }
}
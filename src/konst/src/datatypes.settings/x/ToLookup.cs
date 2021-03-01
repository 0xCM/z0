//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static SettingsLookup Settings(this ISettingsSet src)
            => new SettingsLookup(src.Settings);
    }
}
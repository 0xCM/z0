//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Settings
    {
        [MethodImpl(Inline), Op]
        public static Setting setting(string name, dynamic value)
            => new Setting(name,value);
    }
}
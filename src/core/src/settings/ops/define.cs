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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Setting<T> define<T>(string name, T value)
            => new Setting<T>(name,value);
    }
}
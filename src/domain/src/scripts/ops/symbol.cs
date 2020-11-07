//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        [MethodImpl(Inline), Op]
        public static Symbol symbol(string name)
            => new Symbol(name);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Z0.Clr;

    using static Konst;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static ClrAssembly assembly(Assembly src)
            => new ClrAssembly(src);
    }
}
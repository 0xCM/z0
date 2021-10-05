//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using R = System.Reflection;

    using static Root;
    using static core;

    partial struct ClrModels
    {
        [MethodImpl(Inline), Op]
        public static ClrStructAdapter @struct(Type src)
            => new ClrStructAdapter(src);
    }
}
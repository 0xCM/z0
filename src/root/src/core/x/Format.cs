//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static string Format(this PartId id)
            => Root.format(id);

        [MethodImpl(Inline), Op]
        public static string[] Componentize(this PartId id)
            => Root.componentize(id);
    }
}
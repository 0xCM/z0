//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static string Format(this PartId id)
            => Root.format(id);

        [MethodImpl(Inline), Op]
        public static PartId Id(this Assembly src)
            => Part.id(src);
    }
}
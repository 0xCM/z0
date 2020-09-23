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
        [MethodImpl(Inline)]
        public static string Format(this PartId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static string Format(this ExternId id)
            => Part.format(id);

        [MethodImpl(Inline)]
        public static PartId Id(this Assembly src)
            => Part.id(src);
    }
}
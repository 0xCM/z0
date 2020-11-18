//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XKinds
    {
        [Op]
        public static string Format(this SegBlockKind k)
            => k != 0 ? k.ToString() : string.Empty;
    }
}
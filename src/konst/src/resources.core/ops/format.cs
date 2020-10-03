//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static string format(in TextResourceRow src)
            => text.format(TextResourceRow.RenderPattern, src.Id, src.Address, z.format(Resources.view(src)));
    }
}
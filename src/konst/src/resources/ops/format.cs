//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static string format(in StringResRow src)
            => Z0.text.format(StringResRow.RenderPattern, src.Id, src.Address, z.format(Resources.view(src)));
    }
}
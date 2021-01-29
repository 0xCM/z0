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
            => string.Format("{0} | {1} | {2}", src.Id, src.Address, text.format(view(src)));
    }
}
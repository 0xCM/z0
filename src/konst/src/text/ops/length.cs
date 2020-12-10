//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static int length(string src)
            => src?.Length ?? 0;
    }
}
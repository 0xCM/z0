//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static FS.FileExt combine(FS.FileExt x1, FS.FileExt x2)
            => x1 + x2;
    }
}
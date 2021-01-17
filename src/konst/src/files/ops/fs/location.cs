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
        public static FileLocation location(FS.FilePath src)
            => new FileLocation(src);
    }
}
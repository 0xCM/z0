//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FileSystem
    {
        [MethodImpl(Inline), Op]
        public static FolderPath dir(PathPart name)
            => new FolderPath(name);
    }
}
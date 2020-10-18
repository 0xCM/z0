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

    partial struct ApiFiles
    {
        [MethodImpl(Inline), Op]
        public static IFileArchive filtered(FS.FolderPath root, string filter)
            => new FilteredArchive(root, filter);
    }
}
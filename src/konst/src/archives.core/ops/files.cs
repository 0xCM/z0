//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Archives
    {
        [MethodImpl(Inline), Op]
        public static IEnumerable<FS.FilePath> files(FS.FolderPath root,  bool recurse = true)
            => root.Files(recurse);

        [MethodImpl(Inline), Op]
        public static IEnumerable<FS.FilePath> files(FS.FolderPath root, FS.FileExt ext, bool recurse = true)
            => root.Files(ext, recurse);
    }
}
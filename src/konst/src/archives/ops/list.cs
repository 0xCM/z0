//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Konst;
    using static z;

    partial struct Archives
    {
        [Op]
        public static ListedFiles list(FileArchive src, string pattern, bool recurse)
            => Directory.EnumerateFiles(src.Root.Name, pattern, option(recurse))
                        .Array()
                        .Select(x => FS.path(pattern));
    }
}
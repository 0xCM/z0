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
    using System.Reflection;
    using System.IO;
    using System.Text;

    using static Konst;
    using static z;

    public readonly partial struct FileArchives
    {
        [MethodImpl(Inline)]
        static SearchOption option(bool recurse)
            => recurse ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

        [Op]
        public static ListedFiles list(FileArchive src, string pattern, bool recurse)
            => Directory.EnumerateFiles(src.Root.Name, pattern, option(recurse))
                        .Array()
                        .Select(x => FS.path(pattern));

        [MethodImpl(Inline), Op]
        public static FileKindList kinds(params Assembly[] src)
            => new FileKindList(src.SelectMany(x => x.Types().Tagged<FileKindAttribute>()));
    }
}
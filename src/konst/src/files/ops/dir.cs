//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.IO;

    using static Part;

    partial struct FS
    {
        [MethodImpl(Inline), Op]
        public static FolderPath dir(PathPart name)
            => new FolderPath(normalize(name));

        [MethodImpl(Inline), Op]
        public static FolderPath dir(string name)
            => new FolderPath(normalize(name));


        public static IEnumerable<FS.FolderPath> dir(FS.FolderPath root, bool recurse = true)
        {
            foreach(var path in root.SubDirs(recurse))
                yield return FS.dir(path.Name);
        }
    }
}
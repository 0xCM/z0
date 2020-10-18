//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly partial struct ApiFiles
    {
        [Op]
        public static IEnumerable<FS.FolderPath> directories(FS.FolderPath root, bool recurse = true)
        {
            foreach(var path in root.SubDirs(recurse))
                yield return FS.dir(path.Name);
        }
    }
}
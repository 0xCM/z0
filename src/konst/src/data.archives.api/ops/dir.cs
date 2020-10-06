//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct Archives
    {
        public static IEnumerable<FS.FolderPath> dir(FS.FolderPath root, bool recurse = true)
        {
            foreach(var path in root.SubDirs(recurse))
                yield return FS.dir(path.Name);
        }
    }
}
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

    partial class XTendFS
    {
        public static FS.FilePath PartPath(this IPart part)
            => FS.path(part.Owner.Location);

        public static void Clear(this FS.FolderPath src, bool recurse = false)
            => FS.clear(src, recurse);

        public static List<FS.FilePath> Clear(this FS.FolderPath src, List<FS.FilePath> dst, bool recurse = false)
            => FS.clear(src, dst, recurse);
    }
}
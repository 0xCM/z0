//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct XedWfOps
    {
        [MethodImpl(Inline), Op]
        public static XedSources SourceArchive(FS.FolderPath root)
            => new XedSources(root);
    }
}
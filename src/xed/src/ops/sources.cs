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
        public static ListedFiles SourceFiles(in XedWfConfig config)
            => Archives.list(FS.dir(config.SourceRoot.Name),"*.*", true);

        [MethodImpl(Inline), Op]
        public static XedSourceArchive SourceArchive(FS.FolderPath root)
            => new XedSourceArchive(root);
    }
}
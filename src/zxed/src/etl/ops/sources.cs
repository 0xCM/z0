//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct XedOps
    {
        [MethodImpl(Inline), Op]
        public static ListedFiles SourceFiles(in XedConfig config)
            => Archives.list(FS.dir(config.SourceRoot.Name),"*.*", true);

        [MethodImpl(Inline), Op]
        public static XedSourceArchive SourceArchive(FS.FolderPath root)
            => new XedSourceArchive(root);
    }
}
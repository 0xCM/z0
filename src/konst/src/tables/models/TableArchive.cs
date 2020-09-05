//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableArchive
    {
        public FS.FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        public TableArchive(FS.FolderPath root)
        {
            ArchiveRoot = root;
        }
    }
}
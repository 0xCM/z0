//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Data;

    using static Konst;

    public readonly struct TableArchive : ITableArchive
    {


        public FolderPath ArchiveRoot {get;}

        [MethodImpl(Inline)]
        public TableArchive(FolderPath root)
        {
            ArchiveRoot = root;
        }
    }
}
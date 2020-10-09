//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static Konst;
    using static z;

    public struct DbOptions
    {
        public FS.FolderPath Root;

        public FS.FolderPath Tables;

        public FS.FolderPath Docs;

        public FS.FolderPath Sources;

        public FS.FolderPath Stage;
    }
}
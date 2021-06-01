//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    public partial class BdDisasm : AppService<BdDisasm>
    {
        public readonly struct Repo : IFileArchive
        {
            public FS.FolderPath Root {get;}

            public Repo(FS.FolderPath root)
            {
                Root = root;
            }
        }

    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
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
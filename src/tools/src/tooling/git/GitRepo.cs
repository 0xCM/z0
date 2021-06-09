//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    public readonly struct GitRepo : IFileArchive
    {
        public FS.FolderPath Root {get;}

        public GitRepo(FS.FolderPath root)
        {
            Root = root;
        }
    }

}
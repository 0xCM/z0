//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    public readonly struct CodeRepo : IFileArchive
    {
        public FS.FolderPath Root {get;}

        public CodeRepo(FS.FolderPath root)
        {
            Root = root;
        }
    }
}
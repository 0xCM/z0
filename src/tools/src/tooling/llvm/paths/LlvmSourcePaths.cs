//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    public interface ILlvmSourcePaths : IFileArchive
    {
        FS.FolderPath IncludeDir
            => Root + FS.folder("include");
    }

    partial struct Llvm
    {
        internal readonly struct SourcePaths : ILlvmSourcePaths
        {
            public FS.FolderPath Root {get;}

            public SourcePaths(FS.FolderPath root)
                => Root = root;

            public FS.FolderPath IncludeDir
                => Root + FS.folder("include");
        }
    }
}
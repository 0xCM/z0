//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFolderPaths : IPartFolderNames
    {

        FolderPath X86DirPath(FolderPath root)
            => (root + X86FolderName);

        FolderPath AsmDirPath(FolderPath root)
            => (root + AsmFolderName);

        FS.FolderPath AsmSemanticDirPath(FS.FolderPath root)
            => (root + AsmFolderName);

    }
}
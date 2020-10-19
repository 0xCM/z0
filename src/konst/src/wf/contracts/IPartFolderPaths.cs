//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFolderPaths : IPartFolderNames
    {
        FolderPath ExtractDirPath(FolderPath root)
            => (root + ExtractFolderName).Create();

        FolderPath ParsedDirPath(FolderPath root)
            => (root + ParsedFolderName).Create();

        FolderPath X86DirPath(FolderPath root)
            => (root + X86FolderName).Create();

        FolderPath CilDirPath(FolderPath root)
            => (root + CilFolderName).Create();

        FolderPath AsmDirPath(FolderPath root)
            => (root + AsmFolderName).Create();
    }
}
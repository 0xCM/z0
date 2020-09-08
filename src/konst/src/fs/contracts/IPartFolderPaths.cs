//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFolderPaths : IPartFolderNames
    {
        FolderPath ShellDataDir(FolderPath root)
            => root + ShellFolder;

        FolderPath ExtractDirPath(FolderPath root)
            => (root + ExtractFolderName).Create();

        FolderPath UnparsedDirPath(FolderPath root)
            => (root + UnparsedFolderName).Create();

        FolderPath ParsedDirPath(FolderPath root)
            => (root + ParsedFolderName).Create();

        FolderPath HexDirPath(FolderPath root)
            => (root + HexFolderName).Create();

        FolderPath CilDataDirPath(FolderPath root)
            => (root + CilDataFolderName).Create();

        FolderPath AsmDirPath(FolderPath root)
            => (root + AsmFolderName).Create();

        FolderPath LogDirPath(FolderPath root)
            => (root + LogsFolder).Create();
    }
}
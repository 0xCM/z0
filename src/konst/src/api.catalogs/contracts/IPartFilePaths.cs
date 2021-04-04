//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static ArchiveFolders;

    using X = FS.Extensions;

    public interface IPartFilePaths : IFileArchive
    {
        FS.FolderPath HexDir(FS.FolderPath root)
            => (root + FS.folder(HexFolder));

        FS.FolderPath AsmDirPath(FS.FolderPath root)
            => (root + FS.folder(AsmFolder));

        FS.FilePath HexFilePath(FS.FolderPath root, FS.FileName name)
            => HexDir(root) + name;

        FS.FilePath HexFilePath(FS.FolderPath root, ApiHostUri host)
            => HexDir(root) + FS.file(host.Name, X.Hex);

        FS.FilePath AsmFilePath(FS.FolderPath root, FS.FileName name)
            => AsmDirPath(root) + name;
    }
}
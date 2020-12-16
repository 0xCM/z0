//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using L = ArchiveFolderNames;

    public interface IPartFilePaths : IPartFileNames, IFileArchive
    {
        FS.FolderPath X86DirPath(FS.FolderPath root)
            => (root + FS.folder(L.Hex));

        FS.FolderPath AsmDirPath(FS.FolderPath root)
            => (root + FS.folder(L.Asm));

        FS.FilePath HexFilePath(FS.FolderPath root, FS.FileName name)
            => X86DirPath(root) + name;

        FS.FilePath HexFilePath(FS.FolderPath root, ApiHostUri host)
            => X86DirPath(root) + FS.file(host.Name, Hex);

        FS.FilePath AsmFilePath(FS.FolderPath root, FS.FileName name)
            => AsmDirPath(root) + name;
    }
}
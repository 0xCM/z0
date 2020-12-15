//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFilePaths : IPartFolderNames, IPartFileNames
    {
        /// <summary>
        /// The path to which all archive path arithmetic is relative
        /// </summary>
        FS.FolderPath ArchiveRoot {get;}

        FS.FolderPath X86DirPath(FS.FolderPath root)
            => (root + X86FolderName);

        FolderPath AsmDirPath(FS.FolderPath root)
            => (root + AsmFolderName);

        FS.FolderPath AsmSemanticDirPath(FS.FolderPath root)
            => (root + AsmFolderName);

        FilePath HexFilePath(FS.FolderPath root, FS.FileName name)
            => X86DirPath(root) + name;

        FilePath HexFilePath(FS.FolderPath root, ApiHostUri host)
            => X86DirPath(root) + FS.file(host.Name, FileExtensions.Hex);

        FilePath AsmFilePath(FS.FolderPath root, FS.FileName name)
            => AsmDirPath(root) + name;
    }
}
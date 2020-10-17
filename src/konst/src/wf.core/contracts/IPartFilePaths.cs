//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFilePaths : IPartFileExtensions, IPartFolderNames, IPartFileNames, IPartFolderPaths
    {
        FilePath HexFilePath(FolderPath root, FileName name)
            => X86DirPath(root) + name;

        FilePath HexFilePath(FolderPath root, ApiHostUri host)
            => X86DirPath(root) + FileName.define(host.Name, HexLine);

        FilePath AsmFilePath(FolderPath root, FileName name)
            => AsmDirPath(root) + name;

        FilePath[] AsmFilePaths(FolderPath root)
            => AsmDirPath(root).Files(Asm);

        FilePath[] HexFilePaths(FolderPath root)
            => X86DirPath(root).Files(HexLine);

        FilePath[] ParseFilePaths(FolderPath root)
            => ParsedDirPath(root).Files(Parsed);

        /// <summary>
        /// The path to which all archive path arithmetic is relative
        /// </summary>
        FolderPath ArchiveRoot
            => FolderPath.Define(EnvVars.Common.LogRoot.Name);
    }
}
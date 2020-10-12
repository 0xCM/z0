//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFilePaths : IPartFileExtensions, IPartFolderNames, IPartFileNames, IPartFolderPaths, IPartLogPaths, IPartResPaths
    {
        FilePath HexFilePath(FolderPath root, FileName name)
            => X86DirPath(root) + name;

        FilePath HexFilePath(FolderPath root, ApiHostUri host)
            => X86DirPath(root) + FileName.define(host.Name, HexLine);

        FilePath HexFilePath<T>(FolderPath root)
            => HexFilePath(root, FileName.define(typeof(T).Name, HexLine));

        FilePath AsmFilePath(FolderPath root, FileName name)
            => AsmDirPath(root) + name;

        FilePath AsmFilePath<T>(FolderPath root)
            => AsmFilePath(root, FileName.define(typeof(T).Name, Asm));

        FilePath AsmFilePath(FolderPath root, ApiHostUri host)
            => AsmDirPath(root) + FileName.define(host.Name, Asm);

        FilePath UnparsedFilePath(FolderPath root, ApiHostUri host)
            => UnparsedDirPath(root) + FileName.define($"{host.Owner.Format()}.{host.Name}", Unparsed);

        FilePath[] AsmFilePaths(FolderPath root)
            => AsmDirPath(root).Files(Asm);

        FilePath[] HexFilePaths(FolderPath root)
            => X86DirPath(root).Files(HexLine);

        FilePath[] ExtractFilePaths(FolderPath root)
            => ExtractDirPath(root).Files(Extract);

        FilePath[] ParseFilePaths(FolderPath root)
            => ParsedDirPath(root).Files(Parsed);

        /// <summary>
        /// The path to which all archive path arithmetic is relative
        /// </summary>
        FolderPath ArchiveRoot
            => FolderPath.Define(EnvVars.Common.LogRoot.Name);
    }
}
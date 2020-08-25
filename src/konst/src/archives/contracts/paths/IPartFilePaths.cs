//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public interface IPartFilePaths : IPartFileExtensions, IPartFolderNames, IPartFileNames, IPartFolderPaths, IPartLogPaths, IPartResPaths
    {
        /// <summary>
        /// Nonrecursively enumerates the files in a directory owned by one of a supplied list of parts
        /// </summary>
        /// <param name="src">The directory to search</param>
        /// <param name="parts">The owning parts</param>
        FilePath[] PartFilePaths(FolderPath src, params PartId[] parts)
            =>  (from part in parts
                from file in src.Files(part)
                select file).Array();

        FilePath HexFilePath(FolderPath root, FileName name)
            => HexDirPath(root) + name;

        FilePath HexFilePath(FolderPath root, ApiHostUri host)
            => HexDirPath(root) + FileName.Define(host.Name, HexLine);

        FilePath HexFilePath<T>(FolderPath root)
            => HexFilePath(root, FileName.Define(typeof(T).Name, HexLine));

        FilePath AsmFilePath(FolderPath root, FileName name)
            => AsmDirPath(root) + name;
        FilePath AsmFilePath<T>(FolderPath root)
            => AsmFilePath(root, FileName.Define(typeof(T).Name, Asm));

        FilePath AsmFilePath(FolderPath root, ApiHostUri host)
            => AsmDirPath(root) + FileName.Define(host.Name, Asm);

        FilePath ExtractFilePath(FolderPath root, ApiHostUri host)
            => ExtractDirPath(root) + FileName.Define(host.Name, Extract);

        FilePath UnparsedFilePath(FolderPath root, ApiHostUri host)
            => UnparsedDirPath(root) + FileName.Define($"{host.Owner.Format()}.{host.Name}", Unparsed);

        FilePath ParseFilePath(FolderPath root, ApiHostUri host)
            => ParsedDirPath(root) + FileName.Define(host.Name, Parsed);

        FilePath[] AsmFilePaths(FolderPath root)
            => AsmDirPath(root).Files(Asm);

        FilePath[] HexFilePaths(FolderPath root)
            => HexDirPath(root).Files(HexLine);

        FilePath[] ExtractFilePaths(FolderPath root)
            => ExtractDirPath(root).Files(Extract);

        FilePath[] ParseFilePaths(FolderPath root)
            => ParsedDirPath(root).Files(Parsed);


        /// <summary>
        /// The path to which all archive path arithmetic is relative
        /// </summary>
        FolderPath ArchiveRoot
            => EnvVars.Common.LogRoot;

        /// <summary>
        /// A folder name of the form PartFolder(part):{TestPartition | AppPartition} as determined by the identifier of the entry process
        /// </summary>
        FolderName RootPartition
            => Part.isTest(Part.ExecutingPart) ? TestFolderName : AppFolderName;

        /// <summary>
        /// Defines a path that determines the root directory for process-specific archives
        /// and is of the form {ArchiveRoot}/{RootPartition}
        /// </summary>
        FolderPath ExeRoot
            => ArchiveRoot + RootPartition;

        /// <summary>
        /// Defines a process-specific path of the form {ExeRoot}/{ExeFolder} where
        /// ExeFolder := PartFolder(part:PartId) and {part} is the identifier of the entry process
        /// </summary>
        FolderPath PartExeDir
            => ExeRoot + PartExeFolderName;

        FolderPath PartDataDir(FolderName folder)
            => (PartExeDir + DataFolderName) + folder;

        FolderPath PartDataDir(Type t)
            => PartDataDir(TypeFolderName(t));

        /// <summary>
        /// Defines a path of the form {ExeDir}/{folder}
        /// </summary>
        /// <param name="folder">The source folder</param>
        FolderPath ExeSubDir(FolderName folder)
            => PartExeDir + folder;

        /// <summary>
        /// Defines a path of the form {ExeRoot}/{ExeDir}/{part:Folder}
        /// </summary>
        /// <param name="part">The source part</param>
        FolderPath PartDir(PartId part)
            => ExeSubDir(PartFolderName(part));
    }
}
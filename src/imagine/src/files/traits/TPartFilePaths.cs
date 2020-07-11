//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System.Linq;

    public interface TPartFilePaths : TPartFileExtensions, TPartFolderNames, TPartFileNames, TPartFolderPaths, TPartLogPaths
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
            => HexDirPath(root) + FileName.Define(host.Name, Hex);

        FilePath HexFilePath<T>(FolderPath root)
            => HexFilePath(root, FileName.Define(typeof(T).Name, Hex));

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
            => AsmDirPath(root) .Files(Asm);  

        FilePath[] HexFilePaths(FolderPath root) 
            => HexDirPath(root).Files(Hex);     

        FilePath[] ExtractFilePaths(FolderPath root) 
            => ExtractDirPath(root).Files(Extract);     

        FilePath[] ParseFilePaths(FolderPath root) 
            => ParsedDirPath(root).Files(Parsed);
    }
}
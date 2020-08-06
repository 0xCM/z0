//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFolderPaths : IPartFolderNames
    {
        FolderPath DataRootPath(FolderPath root)
            => root + DataFolderName;

        FolderPath DataFolderPath(FolderPath root, FolderName subfolder)
            => DataRootPath(root) + subfolder;

        FolderPath PartExeRoot(FolderPath root)
            => root + AppFolderName;

        FolderPath PartDataDir(FolderPath root, FolderName folder)            
            => (((root + AppFolderName) + PartExeFolderName) + DataFolderName) + folder;        

        FolderPath PartExtractDir(FolderPath root) 
            => (root + ExtractFolderName).Create();

        FolderPath PartUnparsedDir(FolderPath root)
            => (root + UnparsedFolderName).Create();

        FolderPath PartParsedDir(FolderPath root)
            => (root + ParsedFolderName).Create();
        
        FolderPath PartHexDir(FolderPath root) 
            => (root + HexFolderName).Create();
    
        FolderPath PartAsmDir(FolderPath root) 
            => (root + AsmFolderName).Create();

        FolderPath HostDir(FolderPath root, ApiHostUri host)
            => root + RelativeLocation.Define(PartFolderName(host.Owner), HostFolderName(host));

        FolderPath ExtractDirPath(FolderPath root) 
            => (root + ExtractFolderName).Create();

        FolderPath UnparsedDirPath(FolderPath root) 
            => (root + UnparsedFolderName).Create();

        FolderPath ParsedDirPath(FolderPath root) 
            => (root + ParsedFolderName).Create();

        FolderPath HexDirPath(FolderPath root) 
            => (root + HexFolderName).Create();

        FolderPath AsmDirPath(FolderPath root) 
            => (root + AsmFolderName).Create();

        FolderPath LogDirPath(FolderPath root) 
            => (root + LogFolderName).Create();

        FolderPath LogDirPath(FolderPath root, PartId id) 
            => (PartExeRoot(root) + LogFolderName).Create();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface TTestLogPaths : TPartFolderPaths, TPartLogExtensions  
    {
        FolderPath TestRootPath(FolderPath root)
            => root + TestFolderName;        
            
        FilePath TestMessages(FolderPath root,  PartId id)
            => TestRootPath(root) + FileName.Define(id.Format(), StdOut);
    
        FilePath TestErrors(FolderPath root,  PartId id)
            => TestRootPath(root) + FileName.Define(id.Format(), ErrOut);
    }
}
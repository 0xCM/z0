//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface TLocalArchive
    {
        FolderPath ArchiveRoot {get;}

        void Clear() 
            => ArchiveRoot.Clear();

        void Clear(FolderName folder) 
            => SubFolder(folder).Clear();

        FolderPath SubFolder(FolderName folder) 
            => ArchiveRoot + folder;
    }
}
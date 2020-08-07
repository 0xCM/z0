//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;

    public interface ITabularArchive
    {
        FolderPath ArchiveRoot {get;}            
        
        Option<FilePath> Deposit<F,R>(R[] src, FileName name)
            where F : unmanaged, Enum
            where R : ITabular;

        Option<FilePath> Deposit<F,R>(R[] src, FolderName folder, FileName name)
            where F : unmanaged, Enum
            where R : ITabular;

        void Clear()
            => ArchiveRoot.Clear();
        
        void Clear(FolderName folder)
            => (ArchiveRoot + folder).Clear();
    }
}
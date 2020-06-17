//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ILocalArchive : IService
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
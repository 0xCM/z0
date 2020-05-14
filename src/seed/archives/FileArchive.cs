//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    
    using static Seed;

    public readonly struct FileArchive : IArchive
    {        
        public static FileArchive Empty => new FileArchive(FolderPath.Empty);
        
        public static IArchive Create(FolderPath root = null)
            => new FileArchive(root ?? Env.Current.LogDir);

        FileArchive(FolderPath root)
        {
            ArchiveRoot = root;
        }

        public FolderPath ArchiveRoot {get;}

    }
}
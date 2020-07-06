//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct FileArchive : TArchive
    {        
        public static FileArchive Empty => new FileArchive(FolderPath.Empty);
        
        [MethodImpl(Inline)]
        public static TArchive Create(FolderPath root = null)
            => new FileArchive(root ?? Env.Current.LogDir);

        [MethodImpl(Inline)]
        FileArchive(FolderPath root)
        {
            ArchiveRoot = root;
        }

        public FolderPath ArchiveRoot {get;}
    }
}
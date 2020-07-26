//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DllArchiveConfig
    {
        public readonly FolderPath ArchiveRoot;        
        
        public DllArchiveConfig(FolderPath root)
        {
            ArchiveRoot = root;
        }
        
        [MethodImpl(Inline)]
        public static implicit operator ArchiveConfig(DllArchiveConfig src)
            => new ArchiveConfig(src.ArchiveRoot);
    }
}
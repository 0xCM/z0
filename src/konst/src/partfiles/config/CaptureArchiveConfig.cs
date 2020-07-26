//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CaptureArchiveConfig
    {
        public readonly FolderPath ArchiveRoot;

        [MethodImpl(Inline)]
        public CaptureArchiveConfig(FolderPath root)
        {
            ArchiveRoot = root;
        }        

        [MethodImpl(Inline)]
        public static implicit operator ArchiveConfig(CaptureArchiveConfig src)
            => new ArchiveConfig(src.ArchiveRoot);        
    }
}
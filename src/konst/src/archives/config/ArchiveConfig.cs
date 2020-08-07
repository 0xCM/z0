//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ArchiveConfig : ITextual
    {
        public readonly FolderPath ArchiveRoot;

        [MethodImpl(Inline)]
        public ArchiveConfig(FolderPath root)
            => ArchiveRoot = root;

        public string Format()
            => ArchiveRoot.Name;

        
        public override string ToString()
            => Format();
    }
}
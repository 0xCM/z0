//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ArchiveConfig : ITextual
    {
        public FS.FolderPath Root;

        [MethodImpl(Inline)]
        public ArchiveConfig(FolderPath root)
            => Root = FS.dir(root.Name);

        [MethodImpl(Inline)]
        public ArchiveConfig(FS.FolderPath root)
            => Root = root;

        [MethodImpl(Inline)]
        public string Format()
            => Root.Name;

        public override string ToString()
            => Format();
    }
}
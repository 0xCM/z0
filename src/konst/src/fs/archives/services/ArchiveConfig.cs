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
        public readonly FolderPath Root;

        [MethodImpl(Inline)]
        public ArchiveConfig(FolderPath root)
            => Root = root;

        [MethodImpl(Inline)]
        public ArchiveConfig(FS.FolderPath root)
            => Root = FolderPath.Define(root.Name);
        public string Format()
            => Root.Name;

        public override string ToString()
            => Format();
    }
}
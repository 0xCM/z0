//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct BuildArchive : IBuildArchive
    {
        [MethodImpl(Inline)]
        public static IBuildArchive create(FS.FolderPath root)
            => new BuildArchive(root);

        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public BuildArchive(FS.FolderPath root)
        {
            Root = root;
        }
    }
}
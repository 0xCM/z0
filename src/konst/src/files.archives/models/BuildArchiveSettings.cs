//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct BuildArchiveSettings
    {
        public FS.FolderPath Root;

        [MethodImpl(Inline)]
        public BuildArchiveSettings(FS.FolderPath root)
        {
            Root = root;
        }
    }
}
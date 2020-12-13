//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Provides the canonical <see cref='IWfPaths'/> implementation
    /// </summary>
    public readonly struct WfPaths : IWfPaths
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public WfPaths(FS.FolderPath root)
            => Root = root;
    }
}
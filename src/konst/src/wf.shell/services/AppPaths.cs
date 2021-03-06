//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AppPaths : IAppPaths
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public AppPaths(FS.FolderPath root)
            => Root = root;
    }
}
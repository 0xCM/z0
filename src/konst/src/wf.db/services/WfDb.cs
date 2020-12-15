//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Service]
    public readonly struct WfDb : IWfDb, IService<WfDb,IWfDb>
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        internal WfDb(FS.FolderPath root)
            => Root = root;
    }
}
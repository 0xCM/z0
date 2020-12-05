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
    /// Reifies default application path service
    /// </summary>
    public readonly struct WfPaths : IWfPaths
    {
        public FS.FolderPath Root {get;}

        public WfPaths(FS.FolderPath root)
            => Root = root;
    }

    /// <summary>
    /// Reifies default application path service
    /// </summary>
    public readonly struct WfPaths<A> : IWfPaths<A>
    {
        public FS.FolderPath Root {get;}

        public WfPaths(FS.FolderPath root)
            => Root = root;
    }
}
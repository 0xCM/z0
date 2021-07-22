//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static EnvFolders;
    using static core;

    public sealed class Workspaces
    {
        public static Workspaces dev(IEnvProvider env)
        {
            var roots = env.Env.DevWs.SubDirs().View;
            var count = roots.Length;
            var buffer = core.alloc<IWorkspace>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = new Workspace(skip(roots,i));
            return new Workspaces(buffer);
        }

        readonly Index<IWorkspace> Data;

        internal Workspaces(IWorkspace[] src)
        {
            Data = src;
        }
    }
}
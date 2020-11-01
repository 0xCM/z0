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

    partial struct Tooling
    {
        [Op]
        public static ToolPaths paths(KeyedValues<CmdToolId,FS.FilePath> src)
        {
            var count = (uint)src.Count;
            var tools = alloc<CmdToolId>(count);
            var paths = alloc<FS.FilePath>(count);
            ref var tid = ref tools[0];
            ref var pid = ref paths[0];
            ref readonly var kv = ref src.First;
            for(var i=0u; i<count; i++)
            {
                ref readonly var pair = ref skip(kv,i);
                seek(tid,i) = pair.Key;
                seek(pid,i) = pair.Value;
            }
            return new ToolPaths(tools, paths);
        }
    }
}
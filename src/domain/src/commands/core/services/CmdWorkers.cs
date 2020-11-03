//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public sealed class CmdWorkers : ConcurrentDictionary<CmdId,CmdWorker>
    {
        public static CmdWorkers create(params KeyedValue<CmdId,CmdWorker>[] src)
        {
            var dst = new CmdWorkers();
            iter(src, kv => dst.TryAdd(kv.Key, kv.Value));
            return dst;
        }
    }
}
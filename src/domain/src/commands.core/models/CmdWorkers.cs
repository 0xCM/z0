//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    public sealed class CmdWorkers : ConcurrentDictionary<CmdId,ICmdWorker>
    {
        public static CmdWorkers create(params KeyedValue<CmdId,ICmdWorker>[] src)
        {
            var dst = new CmdWorkers();
            iter(src, kv => dst.TryAdd(kv.Key, kv.Value));
            return dst;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public sealed class WfCmdIndex : Dictionary<ulong,WfCmdExec>
    {
        public static WfCmdIndex create()
            => new WfCmdIndex();

        public WfCmdExec<K> Include<K>(K kind, WfCmdExec cmd)
            where K : unmanaged
        {

            this[bw64(kind)] = cmd;
            return (kind, cmd);
        }

        public WfCmdExec<K> Include<K>(WfCmdExec<K> cmd)
            where K : unmanaged
        {
            this[bw64(cmd.Kind)] = cmd;
            return cmd;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Part;

    [ApiHost]
    public readonly struct WfCmd
    {
        [MethodImpl(Inline), Op]
        public static WfCmdExec define(Name name)
            => new WfCmdExec(name);

        public static WfCmdExec<K> define<K>(K kind)
            where K : unmanaged
                => (kind, new WfCmdExec(kind.ToString()));

        [Op]
        public static void assign(string name, Action handler)
        {
            if(!_Lookup.TryAdd(name, handler))
                root.@throw(string.Format("{0}:Unable to include {1}", nameof(WfCmd), name));
        }

        [Op]
        public static WfCmdExec assign(WfCmdExec cmd, Action handler)
        {
            assign(cmd.WorkflowName, handler);
            return cmd;
        }

        public static WfCmdExec<K> assign<K>(WfCmdExec<K> cmd, Action handler)
            where K : unmanaged
        {
            assign(cmd.Enclosed.WorkflowName, handler);
            return cmd;
        }

        public static WfCmdExec<K> assign<K>(K kind, Action handler)
            where K : unmanaged
                => assign(define(kind),handler);

        public static bool find(WfCmdExec cmd, out Action handler)
            => _Lookup.TryGetValue(cmd.WorkflowName, out handler);

        [Op]
        public static bool find(Name name, out WfCmdExec cmd)
        {
            if(_Lookup.ContainsKey(name))
            {
                cmd = name;
                return true;
            }
            else
            {
                cmd = WfCmdExec.Empty;
                return false;
            }
        }

        public static bool find<K>(K kind, out WfCmdExec<K> cmd)
            where K : unmanaged
        {
            if(find(kind.ToString(), out var c))
            {
                cmd = (kind,c);
                return true;
            }
            else
            {
                cmd = (kind, WfCmdExec.Empty);
                return false;
            }
        }

        static ConcurrentDictionary<string,Action> _Lookup = new ConcurrentDictionary<string, Action>();
    }
}
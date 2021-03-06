//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public sealed class WfCmdIndex : Dictionary<ulong,ExecWorkflowCmd>
    {
        public ExecWorkflowCmd<K> Include<K>(K kind, ExecWorkflowCmd cmd)
            where K : unmanaged
        {

            this[bw64(kind)] = cmd;
            return (kind, cmd);
        }

        public ExecWorkflowCmd<K> Include<K>(ExecWorkflowCmd<K> cmd)
            where K : unmanaged
        {

            this[bw64(cmd.Kind)] = cmd;
            return cmd;
        }

    }

    public readonly struct WorkflowCommands
    {
        public static ExecWorkflowCmd define(Name name)
            => new ExecWorkflowCmd(name);

        public static ExecWorkflowCmd<K> define<K>(K kind)
            where K : unmanaged
                => (kind, new ExecWorkflowCmd(kind.ToString()));

        public static void assign(string name, Action handler)
        {
            if(!_Lookup.TryAdd(name, handler))
                root.@throw(string.Format("{0}:Unable to include {1}", nameof(WorkflowCommands), name));

        }

        public static ExecWorkflowCmd assign(ExecWorkflowCmd cmd, Action handler)
        {
            assign(cmd.WorkflowName, handler);
            return cmd;
        }

        public static ExecWorkflowCmd<K> assign<K>(ExecWorkflowCmd<K> cmd, Action handler)
            where K : unmanaged
        {
            assign(cmd.Enclosed.WorkflowName, handler);
            return cmd;
        }

        public static ExecWorkflowCmd<K> assign<K>(K kind, Action handler)
            where K : unmanaged
                => assign(define(kind),handler);

        public static bool find(ExecWorkflowCmd cmd, out Action handler)
            => _Lookup.TryGetValue(cmd.WorkflowName, out handler);

        public static bool find(Name name, out ExecWorkflowCmd cmd)
        {
            if(_Lookup.ContainsKey(name))
            {
                cmd = name;
                return true;
            }
            else
            {
                cmd = ExecWorkflowCmd.Empty;
                return false;
            }
        }

        public static bool find<K>(K kind, out ExecWorkflowCmd<K> cmd)
            where K : unmanaged
        {
            if(find(kind.ToString(), out var c))
            {
                cmd = (kind,c);
                return true;
            }
            else
            {
                cmd = (kind, ExecWorkflowCmd.Empty);
                return false;
            }
        }

        static ConcurrentDictionary<string,Action> _Lookup = new ConcurrentDictionary<string, Action>();
    }
}
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

    [Cmd(CmdName)]
    public struct ExecWorkflowCmd : ICmd<ExecWorkflowCmd>
    {
        public const string CmdName = "exec-wf";

        public Name WorkflowName;

        [MethodImpl(Inline)]
        public ExecWorkflowCmd(Name name)
            => WorkflowName = name;

        [MethodImpl(Inline)]
        public bool Equals(ExecWorkflowCmd src)
            => WorkflowName.Equals(src.WorkflowName);

        public override int GetHashCode()
            => WorkflowName.GetHashCode();

        public override bool Equals(object src)
            => src is ExecWorkflowCmd c && Equals(c);

        [MethodImpl(Inline)]
        public static implicit operator ExecWorkflowCmd(string name)
            => new ExecWorkflowCmd(name);

        [MethodImpl(Inline)]
        public static implicit operator ExecWorkflowCmd(Name name)
            => new ExecWorkflowCmd(name);

        public static bool operator ==(ExecWorkflowCmd a, ExecWorkflowCmd b)
            => a.Equals(b);

        public static bool operator !=(ExecWorkflowCmd a, ExecWorkflowCmd b)
            => !a.Equals(b);

        public static ExecWorkflowCmd Empty => new ExecWorkflowCmd(Name.Empty);
    }

    public readonly struct WorkflowCommands
    {
        public static ExecWorkflowCmd define(Name name)
            => new ExecWorkflowCmd(name);

        public static void assign(string name, Action handler)
            => _Lookup.TryAdd(name, handler);

        public static void assign(ExecWorkflowCmd cmd, Action handler)
            => assign(cmd.WorkflowName, handler);

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

        static ConcurrentDictionary<string,Action> _Lookup = new ConcurrentDictionary<string, Action>();
    }
}
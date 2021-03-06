//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct ExecWorkflowCmd<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public ExecWorkflowCmd Enclosed {get;}

        [MethodImpl(Inline)]
        public ExecWorkflowCmd(K kind, ExecWorkflowCmd cmd)
        {
            Kind = kind;
            Enclosed = cmd;
        }

        [MethodImpl(Inline)]
        public static implicit operator ExecWorkflowCmd(ExecWorkflowCmd<K> src)
            => src.Enclosed;

        [MethodImpl(Inline)]
        public static implicit operator K(ExecWorkflowCmd<K> src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator ExecWorkflowCmd<K>((K kind, ExecWorkflowCmd cmd) src)
            => new ExecWorkflowCmd<K>(src.kind, src.cmd);
    }

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

}
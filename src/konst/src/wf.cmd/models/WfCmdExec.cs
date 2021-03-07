//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct WfCmdExec : ICmd<WfCmdExec>
    {
        public const string CmdName = "exec-wf";

        public Name WorkflowName;

        [MethodImpl(Inline)]
        public WfCmdExec(Name name)
            => WorkflowName = name;

        [MethodImpl(Inline)]
        public bool Equals(WfCmdExec src)
            => WorkflowName.Equals(src.WorkflowName);

        public override int GetHashCode()
            => WorkflowName.GetHashCode();

        public override bool Equals(object src)
            => src is WfCmdExec c && Equals(c);

        [MethodImpl(Inline)]
        public static implicit operator WfCmdExec(string name)
            => new WfCmdExec(name);

        [MethodImpl(Inline)]
        public static implicit operator WfCmdExec(Name name)
            => new WfCmdExec(name);

        public static bool operator ==(WfCmdExec a, WfCmdExec b)
            => a.Equals(b);

        public static bool operator !=(WfCmdExec a, WfCmdExec b)
            => !a.Equals(b);

        public static WfCmdExec Empty => new WfCmdExec(Name.Empty);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static WfCmd;

    using K = CliWfCmdKind;

    public enum CliWfCmdKind : byte
    {
        None = 0,

        EmitImageHeaders,
    }

    public sealed class CliWfCmdHost : WfCmdHost<CliWfCmdHost, CliWfCmdKind>
    {
        ImageDataEmitter Emitter;

        protected override void OnInit()
        {
            Emitter = Wf.ImageDataEmitter();
        }

        protected override void RegisterCommands(WfCmdIndex index)
        {
            index.Include(assign(K.EmitImageHeaders, EmitImageHeaders));
        }

        void EmitImageHeaders()
        {
            Emitter.EmitRuntimeHeaders();
        }
    }

}
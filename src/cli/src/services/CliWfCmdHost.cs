//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using K = CliWfCmdKind;

    public enum CliWfCmdKind : byte
    {
        None = 0,

        EmitImageHeaders,

        DumpApiMetadata,
    }

    public sealed class CliWfCmdHost : WfCmdHost<CliWfCmdHost, CliWfCmdKind>
    {
        ImageDataEmitter Emitter;

        CliTables CliTables;

        protected override void OnInit()
        {
            Emitter = Wf.ImageDataEmitter();
            CliTables = Wf.CliTables();
        }

        [Action(K.EmitImageHeaders)]
        void EmitImageHeaders()
            => Emitter.EmitRuntimeHeaders();


        [Action(K.DumpApiMetadata)]
        void DumpApiMetadata()
            => CliTables.DumpApiMetadata();
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public enum CliWfCmdKind : byte
    {
        None = 0,

    }

    public sealed class CliWfCmdHost : WfCmdHost<CliWfCmdHost, CliWfCmdKind>
    {
        ImageMetaPipe Emitter;


        protected override void OnInit()
        {
            Emitter = Wf.ImageMetaPipe();
        }
    }
}
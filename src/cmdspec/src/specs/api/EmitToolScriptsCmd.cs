//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd]
    public struct EmitToolScriptsCmd : ICmd<EmitToolScriptsCmd>
    {
        public ToolId Tool;

        public CmdArgs Args {get;}
    }
}
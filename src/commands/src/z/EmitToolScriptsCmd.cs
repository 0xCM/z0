//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd]
    public struct EmitToolScriptsCmd : ICmdSpec<EmitToolScriptsCmd>
    {
        public CmdHostId Tool;

        public CmdArgs Args {get;}
    }
}
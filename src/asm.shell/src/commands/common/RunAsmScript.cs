//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial class AsmCmdService
    {
        Outcome RunAsmScript(string srcid, ScriptId script)
            => RunAsmScript(srcid,script, out _);

        Outcome RunAsmScript(string srcid, ScriptId script, out ReadOnlySpan<ToolFlow> flows)
        {
            var result = Outcome.Success;
            var vars = WsVars.create();
            var path = AsmWs.Script(script);
            vars.SrcId = srcid;
            return RunToolScript(path, vars.ToCmdVars(), out flows);
        }
    }
}
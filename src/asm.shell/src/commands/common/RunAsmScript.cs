//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        Outcome RunAsmScript(string asmid, ScriptId script)
        {
            var result = Outcome.Success;
            var fence = Rules.fence(Chars.LParen,Chars.RParen);
            var vars = WsVars.create();
            var path = AsmWs.Script(script);
            if(!path.Exists)
                return (false, FS.missing(path));

            vars.SrcId = asmid;
            result = Run(path, vars.ToCmdVars(), out var response);
            var count = response.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var r = ref skip(response,i);
                if(r.IsEmpty)
                    continue;

                var j = text.index(r.Content, Chars.Colon);
                if(j >= 0)
                {
                    var tool = text.left(r.Content,j);
                    var flow = text.right(r.Content,j);
                    j = text.index(flow, "--");
                    if(j>=0)
                    {
                        var src = text.left(flow,j).Trim();
                        var dst = text.right(flow,j + 2).Trim();
                        Write(string.Format("{0}:{1} -> {2}", tool, src, dst));
                    }
                }
            }
            return result;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llasm")]
        Outcome LlAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            var fence = Rules.fence(Chars.LParen,Chars.RParen);

            var vars = WsVars.create();
            vars.SrcId = arg(args,0);
            result = RunScript(AsmWs.Script("ll-assemble"), vars.ToCmdVars(), out var response);
            var count = response.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var r = ref skip(response,i);
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
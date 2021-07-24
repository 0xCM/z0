//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    using SQ = SymbolicQuery;

    partial class AsmCmdService
    {
        [CmdOp(".show-tool-env")]
        Outcome ShowEnv_(CmdArgs args)
        {
            var path = State.Tools().Script("emit-env-config");
            var cmd = Cmd.cmdline(path.Format(PathSeparator.BS));
            var response = ScriptRunner.RunCmd(cmd);
            var count = response.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var line = ref skip(response,i);
                var content = line.Content;
                var j = SQ.index(content, Chars.Colon);
                if(j > 0)
                {
                    var name = SQ.left(content, j).Format();
                    var value = SQ.right(content, j).Format();
                    Write(string.Format("{0}={1}", name, value));
                }
            }

            return true;
        }
    }
}
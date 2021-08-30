//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static core;

    using llvm;

    partial class AsmCmdService
    {
        [CmdOp(".mc-log")]
        Outcome McLog(CmdArgs args)
        {
            var result = Outcome.Success;
            var id = arg(args,0).Value;
            var logs = Ws.Projects().OutFiles(State.Project(),FS.ext("mc.log")).Where(x => x.FileName.Format().StartsWith(id)).View;
            var count = logs.Length;
            for(var i=0; i<count; i++)
            {
                ShowMcLog(skip(logs,i));
            }

            return result;
        }

        void ShowMcLog(FS.FilePath src)
        {
            const string EntryMarker = "note: parsed instruction:";
            var lines = src.ReadNumberedLines();
            var count = lines.Length;
            var segs = count/3;
            for(var i=0; i<segs; i+=3)
            {
                ref readonly var a = ref skip(lines,i).Content;
                ref readonly var b = ref skip(lines,i+1).Content;
                ref readonly var c = ref skip(lines,i+2);

                var m = text.index(a,EntryMarker);
                if(!a.Contains(EntryMarker))
                    continue;

                var file = text.left(a,m);
                var info = text.right(a,m + EntryMarker.Length);
                var body = b.Replace(Chars.Tab,Chars.Space);
                var q = text.index(body,Chars.Hash);
                if(q > 0)
                {
                    var _l = text.left(body, q).Trim();
                    var _r = text.right(body, q).Trim();
                    body = string.Format("{0,-32} # {1}",_l,_r);
                }

                Write(string.Format("{0} - {1}", file, info));
                Write(body);
            }

        }
    }
}
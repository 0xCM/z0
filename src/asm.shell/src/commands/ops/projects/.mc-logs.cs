//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;
    using static Root;

    partial class AsmCmdService
    {
        [CmdOp(".mc-logs")]
        Outcome McLog(CmdArgs args)
        {
            var result = Outcome.Success;
            var project = State.Project();
            var logs = Ws.Projects().OutFiles(project, FileTypes.ext(FileKind.McOpsLog)).View;
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

                Fence<char> Brackets = (Chars.LBracket, Chars.RBracket);
                var locator = text.left(a,m).Trim();
                locator = text.slice(locator,0, locator.Length - 1);

                var info = text.right(a,m + EntryMarker.Length);
                var semfound = text.unfence(info, Brackets, out var semantic);
                info = semfound ? RP.parenthetical(semantic) : info;
                var body = b.Replace(Chars.Tab,Chars.Space);
                var q = text.index(body, Chars.Hash);
                if(q > 0)
                {
                    var _l = text.left(body, q).Trim();
                    var _r = text.right(body, q).Trim();

                    var z = text.index(_l, Chars.Space);
                    var mnemonic = z > 0 ? text.left(_l,z).Trim() : _l;
                    var operands = z > 0 ? text.right(_l,z).Trim() : EmptyString;
                    var xpr = asm.expr(mnemonic, operands);

                    var encfound = text.unfence(_r, Brackets, out var encoding);
                    var cx = asm.comment(string.Format("{0} {1}", encfound ? encoding : _r, info));
                    body = string.Format("{0,-32} {1}", xpr, cx);
                }

                Write(locator);
                Write(body);
            }
        }
    }
}
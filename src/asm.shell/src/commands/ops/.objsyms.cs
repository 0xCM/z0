//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".objsyms")]
        Outcome ObjSyms(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = State.Files(FS.Sym).View;
            var count = src.Length;
            var formatter = Tables.formatter<ObjSymRecord>(ObjSymRecord.RenderWidths);
            var buffer = list<ObjSymRecord>();
            var ws = State.Workspace();
            var outpath = ws.OutDir() + Tables.filename<ObjSymRecord>();
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                using var reader = path.Utf8LineReader();
                while(reader.Next(out var line))
                {
                    var sym = new ObjSymRecord();
                    var content = line.Content;
                    var j = text.index(content, Chars.Colon);
                    if(j > 0)
                    {
                        var k = text.index(content, j + 1, Chars.Colon);
                        if(k > 0)
                        {
                            sym.Source = FS.path(text.left(content,k));
                            var digits = text.slice(text.right(content,k),1,8);
                            if(empty(digits))
                                continue;

                            result = DataParser.parse(digits, out Hex32 hex);
                            if(result.Fail)
                                continue;

                            sym.Offset = hex;
                            var pos = k + 1 + 8 + 2;
                            sym.Kind = content[pos];
                            sym.Name = text.right(content, pos + 1).Trim();
                            buffer.Add(sym);
                        }
                    }
                }
            }
            TableEmit(buffer.ViewDeposited(), ObjSymRecord.RenderWidths, outpath);
            return result;
        }
    }
}
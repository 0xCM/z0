//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.llvm;

    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-record")]
        Outcome LlvmRecord(CmdArgs args)
        {
            var result = Outcome.Success;
            var match = arg(args,0).Value;
            var src = DataSources.Dataset("llvm.tblgen.records", "X86.X86.td-details", FS.Txt);
            using var reader = src.Utf8LineReader();
            var ParsingRecord = false;
            var ParsingFields = false;
            var fields = list<RecordField>();
            var lines = list<TextLine>();
            var name = EmptyString;
            var done = false;
            while(!done && reader.Next(out var line))
            {
                var content = line.Content;

                if(text.begins(content, match))
                {
                    ParsingRecord = true;
                    name = text.left(content, Chars.Space);
                    lines.Add(RecordParser.unpiped(line));
                }
                else if(ParsingRecord)
                {
                    if(empty(content))
                        done = true;
                    else
                    {
                        var i = text.index(content, Chars.Pipe);
                        if(ParsingFields)
                        {
                            if(RecordParser.field(content, out var field))
                                fields.Add(field);

                            lines.Add(RecordParser.unpiped(line));
                        }
                        else if(text.begins(content, RP.Spaced2))
                        {
                            lines.Add(RecordParser.unpiped(line));
                            if(RecordParser.fieldstart(content))
                                ParsingFields = true;
                        }
                        else
                            done = true;
                    }
                }
            }

            if(lines.Count != 0)
            {
                var tgr = new TableGenRecord();
                tgr.EntityName = name;
                tgr.Fields = fields.ToArray();
                tgr.Lines = lines.ToArray();
                Emit(tgr,AsmWs.LlvmRecord(name));
            }

            return result;
         }

         void Emit(TableGenRecord src, FS.FilePath dst)
         {
            using var writer = dst.AsciWriter();
            foreach(var line in src.Lines)
            {
                writer.WriteLine(line.Content);
                Write(line);
            }

            Emitted(dst);

            if(src.Fields.Count != 0)
            {
                iter(src.Fields, f => Write(f));
            }
         }
    }
}
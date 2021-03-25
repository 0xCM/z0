//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static Part;
    using static memory;

    public sealed class XedInstructionPipe : WfService<XedInstructionPipe>
    {
        public struct SourceRecord
        {
            public const byte FieldCount = 6;

            public string Class;

            public string Extension;

            public string Category;

            public string Form;

            public string IsaSet;

            public string Attributes;
        }

        const char CommentMarker = Chars.Hash;

        const char FieldDelimiter = Chars.Space;

        public Index<XedForm> LoadXedForms()
        {
            var records = LoadSourceRecords().View;
            var count = records.Length;
            var buffer = alloc<XedForm>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(records,i);
                seek(dst,i) = new XedForm(record.Form, new AsmMnemonic(record.Class), 0, 0);
            }
            return buffer;
        }

        public Index<SourceRecord> LoadSourceRecords()
        {
            var src = Db.DataSource(FS.file("xed-idata", FS.Extensions.Txt));
            var flow = Wf.Running($"Importing {src.ToUri()}");
            using var reader = src.Reader();
            var counter = 0u;
            var header = memory.alloc<string>(SourceRecord.FieldCount);
            var succeeded = true;
            var records = root.list<SourceRecord>();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadTextLine(counter);
                if(line.StartsWith(CommentMarker))
                    continue;

                if(counter==0)
                {
                    var outcome = ParseSourceHeader(line,header);
                    if(!outcome)
                    {
                        Wf.Error(outcome.Message);
                        succeeded = false;
                        break;
                    }
                }
                else
                {
                   var dst = new SourceRecord();
                   var outcome = ParseSource(line, out dst);
                   if(outcome)
                   {
                       records.Add(dst);
                   }
                   else
                   {
                        Wf.Error(outcome.Message);
                        succeeded = false;
                        break;
                   }
                }

                counter++;
            }

            if(succeeded)
                Wf.Ran(flow, $"Imported {counter} records from {src.ToUri()}");

            return records.ToArray();
        }

        static Outcome ParseSource(TextLine src, out SourceRecord dst)
        {
            dst = default;
            var parts = @readonly(src.Split(FieldDelimiter));
            var count = parts.Length;
            if(count != SourceRecord.FieldCount)
                return(false, $"Line splits into {count} parts, not {SourceRecord.FieldCount} as required");
            var i = 0;
            dst.Class = skip(parts,i++);
            dst.Extension = skip(parts,i++);
            dst.Category = skip(parts,i++);
            dst.Form = skip(parts,i++);
            dst.IsaSet = skip(parts,i++);
            dst.Attributes = skip(parts,i++);
            return true;
        }

        static Outcome ParseSourceHeader(TextLine src, Span<string> dst)
        {
            var parts = @readonly(src.Split(FieldDelimiter));
            var count = parts.Length;
            if(count != SourceRecord.FieldCount)
                return(false, $"Line splits into {count} parts, not {SourceRecord.FieldCount} as required");

            for(var i=0; i<count; i++)
                seek(dst,i) = skip(parts,i);

            return true;
        }
    }
}
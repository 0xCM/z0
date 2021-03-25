//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Part;
    using static memory;
    using static XedModels;

    public sealed class XedServices : WfService<XedServices>
    {
        const char CommentMarker = Chars.Hash;

        const char FieldDelimiter = Chars.Space;

        public Index<XedForm> LoadForms()
        {
            var records = LoadFormSources().View;
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

        public Index<XedFormSource> LoadFormSources()
        {
            var src = Db.DataSource(FS.file("xed-idata", FS.Extensions.Txt));
            var flow = Wf.Running($"Importing {src.ToUri()}");
            using var reader = src.Reader();
            var counter = 0u;
            var header = memory.alloc<string>(XedFormSource.FieldCount);
            var succeeded = true;
            var records = root.list<XedFormSource>();
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
                   var dst = new XedFormSource();
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

        static Outcome ParseSource(TextLine src, out XedFormSource dst)
        {
            dst = default;
            var parts = @readonly(src.Split(FieldDelimiter));
            var count = parts.Length;
            if(count != XedFormSource.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormSource.FieldCount} as required");
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
            if(count != XedFormSource.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormSource.FieldCount} as required");

            for(var i=0; i<count; i++)
                seek(dst,i) = skip(parts,i);

            return true;
        }
    }
}
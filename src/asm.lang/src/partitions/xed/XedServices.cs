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

        IForm ParseIdentifier(string src)
        {
            if(Enum.TryParse<IForm>(src, out var dst))
                return dst;
            else
                return 0;
        }

        IsaKind ParseIsaKind(string src)
        {
            if(Enum.TryParse<IsaKind>(src, out var dst))
                return dst;
            else
                return 0;
        }

        IClass ParseIClass(string src)
        {
            if(Enum.TryParse<IClass>(src, out var dst))
                return dst;
            else
                return 0;
        }

        Category ParseCategory(string src)
        {
            if(Enum.TryParse<Category>(src, out var dst))
                return dst;
            else
                return 0;
        }

        AttributeKind ParseAttribute(string src)
        {
            if(Enum.TryParse<AttributeKind>(src, out var dst))
                return dst;
            else
                return 0;
        }

        Extension ParseExtension(string src)
        {
            if(Enum.TryParse<Extension>(src, out var dst))
                return dst;
            else
                return 0;
        }

        Index<AttributeKind> ParseAttributes(string src)
        {
            var parts = src.SplitClean(Chars.Colon);
            var count = parts.Length;
            return count != 0 ? parts.Select(ParseAttribute) : sys.empty<AttributeKind>();
        }

        XedForm LoadForm(ushort index, XedFormSource src)
        {
            var id = ParseIdentifier(src.Form);
            var iclass = ParseIClass(src.Class);
            var category = ParseCategory(src.Category);
            var attributes = ParseAttributes(src.Attributes);
            var isa = ParseIsaKind(src.IsaSet);
            var ext = ParseExtension(src.Extension);
            return new XedForm((ushort)index, id, iclass, category, attributes, isa, ext);
        }

        public Index<XedForm> LoadForms()
        {
            var records = LoadFormSources().View;
            var count = records.Length;
            var buffer = alloc<XedForm>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = LoadForm((ushort)i, skip(records,i));
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
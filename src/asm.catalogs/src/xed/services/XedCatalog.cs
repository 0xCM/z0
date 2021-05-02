//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static XedModels;

    public sealed class XedCatalog : AppService<XedCatalog>
    {
        public void EmitCatalog()
        {
            EmitSourceAssets();
            EmitFormDetails();
            EmitSymCatalog();
        }

        AsmCatPaths CatPaths
            => new AsmCatPaths(Db);

        public Index<FormDetail> EmitFormDetails()
            => EmitFormDetails(CatPaths.XedFormDetailPath());

        public Index<FormDetail> EmitFormDetails(FS.FilePath dst)
        {
            var records = LoadFormDetails();
            var src = records.View;
            var count = src.Length;
            var flow = Wf.EmittingFile(dst);
            Tables.emit(records.View, dst, FormDetail.FieldWidths);

            // using var writer = dst.Writer();
            // writer.WriteLine(FormDetail.Header);
            // for(var i=0; i<count; i++)
            //     writer.WriteLine(skip(src,i).Format());
            Wf.EmittedFile(flow, count);
            return records;
        }

        public Index<SymLiteral> SymLiterals()
        {
            var src = typeof(XedModels).GetNestedTypes().Enums();
            return Symbols.literals(src);
        }

        public Index<FormDetail> LoadFormDetails()
        {
            var summaries = LoadFormSummaries().View;
            var count = summaries.Length;
            var buffer = alloc<FormDetail>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = LoadDetail((ushort)i, skip(summaries,i));
            return buffer;
        }

        const string Subject = "xed";

        public FS.FilePath EmitSymIndex()
        {
            var src = SymLiterals();
            var dst = CatPaths.XedSymIndexPath();
            EmitSymIndex(dst);
            return dst;
        }

        public Index<SymLiteral> EmitSymIndex(FS.FilePath dst)
        {
            var src = SymLiterals();
            var emitting = Wf.EmittingTable<SymLiteral>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(emitting,count);
            return src;
        }

        public void EmitSymCatalog()
        {
            EmitSymIndex();
            EmitSymbols<AddressWidth>();
            EmitSymbols<AttributeKind>();
            EmitSymbols<Category>();
            EmitSymbols<ChipCode>();
            EmitSymbols<CpuidBit>();
            EmitSymbols<EFlag>();
            EmitSymbols<EncodingGroup>();
            EmitSymbols<Extension>();
            EmitSymbols<IClass>();
            EmitSymbols<IsaKind>();
            EmitSymbols<MachineMode>();
            EmitSymbols<Nonterminal>();
            EmitSymbols<OperandKind>();
            EmitSymbols<OperandWidthType>();
            EmitSymbols<OperandVisibility>();
            EmitSymbols<RegClass>();
            EmitSymbols<RegId>();
            EmitSymbols<RegRole>();
            EmitSymbols<SizeIndicator>();
        }


        public FS.FilePath IDataSourcePath()
            => Db.DataSource(FS.file("xed-idata", FS.Txt));

        public void EmitSourceAssets()
        {
            var dst = IDataSourcePath();
            var flow = Wf.EmittingFile(dst);
            var data = Assets.XedInstructionSummary().Utf8();
            dst.Overwrite(data);
            Wf.EmittedFile(flow, data.Length);
        }

        public void EmitFormSummaries()
        {
            var parser = XedSummaryParser.create(Wf.EventSink);
            var parsed = parser.ParseSummaries();
            EmitFormSummaries(parsed);
        }

        public void EmitFormSummaries(ReadOnlySpan<XedFormInfo> src)
        {
            var dst = Db.CatalogTable<XedFormInfo>("asm", "xed");
            var flow = Wf.EmittingTable<XedFormInfo>(dst);
            var count = Tables.emit(src,dst);
            Wf.EmittedTable(flow,count);
        }

        public Index<XedFormInfo> LoadFormSummaries()
        {
            var src = IDataSourcePath();
            var flow = Wf.Running("Loading xed instruction summaries");
            using var reader = src.Reader();
            var counter = 0u;
            var header = memory.alloc<string>(XedFormInfo.FieldCount);
            var succeeded = true;
            var records = root.list<XedFormInfo>();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine(counter);

                if(line.StartsWith(CommentMarker))
                    continue;

                if(line.IsEmpty)
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
                   var dst = new XedFormInfo();
                   var outcome = ParseSummary(line, out dst);
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

        void EmitSymbols<K>()
            where K : unmanaged, Enum
        {
            EmitSymbols(Symbols.symbolic<K>().View, Db.AsmCatalogPath(Subject,
                FS.file(string.Format("{0}.{1}", Subject,  typeof(K).Name.ToLower()), FS.Csv)));
        }

        void EmitSymbols<K>(ReadOnlySpan<Sym<K>> src, FS.FilePath dst)
            where K : unmanaged
        {
            var count = src.Length;
            if(count != 0)
            {
                var flow = Wf.EmittingFile(dst);
                using var writer = dst.Writer();
                writer.WriteLine(Symbols.header());
                for(var i=0; i<count; i++)
                    writer.WriteLine(skip(src,i));
                Wf.EmittedFile(flow, count);
            }
        }

        const char CommentMarker = Chars.Hash;

        const char FieldDelimiter = Chars.Space;

        static Parts.AsmCatalogs.PartAssets Assets => Parts.AsmCatalogs.Assets;

        IFormType ParseIForm(string src)
        {
            if(Enum.TryParse<IFormType>(src, out var dst))
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

        FormDetail LoadDetail(ushort index, XedFormInfo src)
        {
            var id = ParseIForm(src.Form);
            var iclass = ParseIClass(src.Class);
            var category = ParseCategory(src.Category);
            var attributes = ParseAttributes(src.Attributes);
            var isa = ParseIsaKind(src.IsaSet);
            var ext = ParseExtension(src.Extension);
            return new FormDetail((ushort)index, id, iclass, category, attributes, isa, ext);
        }

        static Outcome ParseSummary(TextLine src, out XedFormInfo dst)
        {
            dst = default;
            var parts = @readonly(src.Split(FieldDelimiter));
            var count = parts.Length;
            if(count != XedFormInfo.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormInfo.FieldCount} as required");
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
            if(count != XedFormInfo.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormInfo.FieldCount} as required");

            for(var i=0; i<count; i++)
                seek(dst,i) = skip(parts,i);

            return true;
        }
    }
}
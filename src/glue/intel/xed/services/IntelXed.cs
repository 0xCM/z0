//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static XedModels;

    public sealed class IntelXed : AppService<IntelXed>
    {
        AsmCatalogArchive Archive;

        XedChipIsaParser ChipIsaParser;

        AsmWorkspace Workspace;

        protected override void OnInit()
        {
            Archive = new AsmCatalogArchive(Db.AsmCatalogRoot());
            ChipIsaParser = XedChipIsaParser.create(Wf);
            Workspace = Wf.AsmWorkspace();
        }

        public void EmitCatalog()
        {
            ImportFormSummaries();
            EmitFormDetails();
            EmitSymCatalog();
            var aspects = EmitFormAspects();
            Partition(aspects);
        }

        public ReadOnlySpan<string> MnemonicNames()
            => IClasses().Storage.Select(x => x.Expr.Text);

        public Outcome LoadChipMap(out ChipMap dst)
        {
            var src = Workspace.DataSource("xed") + FS.file("xed-cdata", FS.Txt);
            return ChipIsaParser.Parse(src, out dst);
        }

        public ReadOnlySpan<FormPartiton> Partition(Index<XedFormAspect> src)
        {
            var aix = src.Select(x => (x.Value, x.Index)).ToDictionary();
            var parts = ComputePartitions();
            var count = parts.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                var pa = part.Aspects.View;
                var ka = pa.Length;
                for(var j=0; j<ka; j++)
                {
                    ref readonly var a = ref skip(pa,j);
                    if(!aix.TryGetValue(a, out var index))
                        Wf.Error(string.Format("Index for {0} not found", a));
                }
            }
            return parts;
        }

        public Index<XedFormAspect> EmitFormAspects()
        {
            var duplicates = dict<Hash32,uint>();
            var aspects = ComputeFormAspects();
            var count = (uint)aspects.Length;
            var buffer = alloc<XedFormAspect>(count);
            var paths = new AsmCatalogArchive(Db.AsmCatalogRoot());
            var path = paths.XedFormAspectPath();
            var formatter = Tables.formatter<XedFormAspect>();
            var emitting = Wf.EmittingTable<XedFormAspect>(path);
            using var writer = path.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0u; i<count; i++)
            {
                ref var record = ref seek(buffer,i);
                ref readonly var aspect = ref skip(aspects,i);
                var value = aspect.Value;

                if(TextTools.length(value) == 0)
                    continue;

                record.Index = i;
                record.Value = value;

                ref readonly var c = ref first(value);
                if(SymbolicQuery.digit(base16, c))
                    record.Name = string.Format("x{0}", value);
                else
                    record.Name = value;
                record.Hash = aspect.GetHashCode();

                if(duplicates.TryGetValue(record.Hash, out var dup))
                    duplicates[record.Hash] = ++dup;
                else
                    duplicates.Add(record.Hash, 0);

                writer.WriteLine(formatter.Format(record));
            }

            var perfect = !duplicates.Values.Array().AnyTest(x => x > 0);
            if(perfect)
                Wf.Status($"Hash Perfect");
            else
                Wf.Warn("Hash Imperfect");

            Wf.EmittedTable(emitting, count);
            return buffer;
        }

        public ReadOnlySpan<FormAspect> ComputeFormAspects()
        {
            var types = IFormTypes();
            var count = types.Count;
            var forms = types.View;
            var distinct = hashset<FormAspect>();
            var counter = 0u;
            for(ushort i=0; i<count; i++)
            {
                var form = skip(forms,i);
                var parts = @readonly(form.Kind.ToString().Split(Chars.Underscore));
                var kParts = parts.Length;
                if(kParts < 2)
                    continue;

                for(var j=1; j<kParts; j++)
                    if(distinct.Add(skip(parts,j)))
                        counter++;
            }

            return distinct.Array().Sort();
       }

        public Index<XedFormDetail> EmitFormDetails()
            => EmitFormDetails(Archive.XedFormDetailPath());

        public Index<XedFormDetail> EmitFormDetails(FS.FilePath dst)
        {
            var records = LoadFormDetails();
            var src = records.View;
            var count = src.Length;
            var flow = Wf.EmittingFile(dst);
            Tables.emit(records.View, dst, XedFormDetail.FieldWidths);
            Wf.EmittedFile(flow, count);
            return records;
        }

        public Index<SymLiteral> SymLiterals()
        {
            var src = typeof(XedModels).GetNestedTypes().Enums();
            return Symbols.literals(src);
        }

        public Index<XedFormDetail> LoadFormDetails()
        {
            var summaries = LoadFormSummaries().View;
            var count = summaries.Length;
            var buffer = alloc<XedFormDetail>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = LoadDetail((ushort)i, skip(summaries,i));
            return buffer;
        }

        const string Subject = "xed";

        public FS.FilePath EmitSymIndex()
        {
            var src = SymLiterals();
            var dst = Archive.XedSymIndexPath();
            EmitSymIndex(dst);
            return dst;
        }

        public Index<SymLiteral> EmitSymIndex(FS.FilePath dst)
        {
            var src = SymLiterals();
            var emitting = Wf.EmittingTable<SymLiteral>(dst);
            var count = Tables.emit(src.View, dst);
            Wf.EmittedTable(emitting,count);
            return src;
        }

        public Symbols<AddressWidth> AddressWidths()
            => Symbols.index<AddressWidth>();

        public Symbols<AttributeKind> AttributeKinds()
            => Symbols.index<AttributeKind>();

        public Symbols<Category> Categories()
            => Symbols.index<Category>();

        public Symbols<ChipCode> ChipCodes()
            => Symbols.index<ChipCode>();

        public Symbols<CpuidBit> CpuidBits()
            => Symbols.index<CpuidBit>();

        public Symbols<EFlag> EFlags()
            => Symbols.index<EFlag>();

        public Symbols<Extension> Extensions()
            => Symbols.index<Extension>();

        public Symbols<EncodingGroup> EncodingGroups()
            => Symbols.index<EncodingGroup>();

        public Symbols<IClass> IClasses()
            => Symbols.index<IClass>();

        public Symbols<IFormType> IFormTypes()
            => Symbols.index<IFormType>();

        public Symbols<IsaKind> IsaKinds()
            => Symbols.index<IsaKind>();

        public Symbols<XedMachineMode> MachineModes()
            => Symbols.index<XedMachineMode>();

        public Symbols<OperandKind> OperandKinds()
            => Symbols.index<OperandKind>();

        public Symbols<RegClass> RegClasses()
            => Symbols.index<RegClass>();

        public Symbols<RegRole> RegRoles()
            => Symbols.index<RegRole>();

        public Symbols<RegId> Registers()
            => Symbols.index<RegId>();

        public Symbols<Nonterminal> Nonterminals()
            => Symbols.index<Nonterminal>();

        public Symbols<SizeIndicator> SizeIndicators()
            => Symbols.index<SizeIndicator>();

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
            EmitSymbols<XedMachineMode>();
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
            => Workspace.DataSource("xed") + FS.file("xed-idata", FS.Txt);

        public void ImportFormSummaries()
        {
            var parser = XedSummaryParser.create(Wf.EventSink);
            var parsed = parser.ParseSummaries(IDataSourcePath());
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
            var header = alloc<string>(XedFormInfo.FieldCount);
            var succeeded = true;
            var records = list<XedFormInfo>();
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
            EmitSymbols(Symbols.index<K>().View, Db.AsmCatalogPath(Subject,
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

        XedFormDetail LoadDetail(ushort index, XedFormInfo src)
        {
            var id = ParseIForm(src.Form);
            var iclass = ParseIClass(src.Class);
            var category = ParseCategory(src.Category);
            var attributes = ParseAttributes(src.Attributes);
            var isa = ParseIsaKind(src.IsaSet);
            var ext = ParseExtension(src.Extension);
            return new XedFormDetail((ushort)index, id, iclass, category, attributes, isa, ext);
        }

        static Outcome ParseSummary(TextLine src, out XedFormInfo dst)
        {
            dst = default;
            var parts = src.Split(FieldDelimiter);
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
            var parts = src.Split(FieldDelimiter);
            var count = parts.Length;
            if(count != XedFormInfo.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormInfo.FieldCount} as required");

            for(var i=0; i<count; i++)
                seek(dst,i) = skip(parts,i);

            return true;
        }

        public ReadOnlySpan<FormPartiton> ComputePartitions()
        {
            var types  = Symbols.index<IFormType>();
            var classes = Symbols.index<IClass>();
            var count = types.Count;
            var buffer = alloc<FormPartiton>(count);
            ref var dst = ref first(buffer);
            var flow = Wf.Running(Msg.PartitioningIForms.Format(count));
            var forms = types.View;
            for(ushort i=0; i<count; i++)
                Partition(classes, i, skip(forms,i), ref seek(dst,i));
            Wf.Ran(flow, Msg.PartitionedIForms.Format(count));
            return buffer;
        }

        void Partition(in Symbols<IClass> classes, ushort index, IFormType src, ref FormPartiton dst)
        {
            dst.Index = index;
            dst.Form = src;
            var candidates = span(src.ToString().Split(Chars.Underscore));
            if(candidates.Length <= 1)
                return;

            dst.Aspects = slice(candidates,1).ToArray();
            ref var parts = ref dst.Aspects.First;
            var count = dst.Aspects.Count;

            for(var i=0; i<count; i++)
            {
                ref readonly var part = ref skip(parts,i);
                if(i ==0)
                {
                    if(!Match(classes, part, out dst.Class))
                    {
                        dst.Complete = false;
                        continue;
                    }
                }
                else
                    Complete(ref dst);
            }
        }

        bool Match(in Symbols<IClass> classes, SymExpr src, out IClass dst)
        {
            if(classes.Lookup(src, out var sym))
            {
                dst = sym.Kind;
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        void Complete(ref FormPartiton partition)
        {
            var count = partition.AspectCount;
            if(count == 0)
                partition.Complete = true;
            else
            {
                ref var parts = ref partition.Aspects[1];
                for(var i=0; i<count; i++)
                {
                    ref readonly var part = ref skip(parts,i);
                }
                partition.Complete = true;
            }
        }
    }
}
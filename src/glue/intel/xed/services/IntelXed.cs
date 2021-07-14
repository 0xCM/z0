//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static XedModels;
    using static XedSourceMarkers;

    public sealed class IntelXed : AppService<IntelXed>
    {
        const string dataset = "xed";

        XedChipIsaParser ChipIsaParser;

        AsmWorkspace Workspace;

        XedParser SourceParser;

        XedDataSource Source;

        protected override void OnInit()
        {
            ChipIsaParser = XedChipIsaParser.create(Wf);
            Workspace = Wf.AsmWorkspace();
            SourceParser = XedParser.Service;
            Source = new XedDataSource(Workspace.DataSource("xed.rules"));
        }

        public void EmitCatalog()
        {
            ImportDir().Clear();
            ImportFormSummaries();
            EmitChipMap();
            EmitFormDetails();
            EmitSymCatalog();
            Partition(EmitFormAspects());
            var patterns = EmitInstructionPatterns();
            var summaries = EmitSummaries(patterns);
            EmitMnemonics(summaries);
            EmitRules();
        }

        public ReadOnlySpan<string> MnemonicNames()
            => IClasses().Storage.Select(x => x.Expr.Text).ToArray();

        public Outcome LoadChipMap(out ChipMap dst)
            => ChipIsaParser.Parse(ChipSourcePath(), out dst);


        public Outcome EmitChipMap()
        {
            const string RowFormat = "{0,-12} | {1,-24} | {2}";

            var outcome = LoadChipMap(out var map);
            if(outcome.Fail)
                Error(outcome.Message);
            else
            {
                var dst = ChipMapImportPath();
                var emitting = Wf.EmittingFile(dst);
                var counter = 0u;
                var writer = dst.AsciWriter();
                writer.WriteLine(string.Format(RowFormat, "Sequence", "ChipCode", "Isa"));
                var kinds = map.Kinds;
                var codes = map.Chips;
                foreach(var code in codes)
                {
                    var mapped = map[code];
                    foreach(var kind in mapped)
                        writer.WriteLine(string.Format(RowFormat, counter++ , code, kind));
                }
                Wf.EmittedFile(emitting,counter);
            }

            return outcome;
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
            var dst = FormAspectImportPath();
            var formatter = Tables.formatter<XedFormAspect>();
            var emitting = Wf.EmittingTable<XedFormAspect>(dst);
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0u; i<count; i++)
            {
                ref var record = ref seek(buffer,i);
                ref readonly var aspect = ref skip(aspects,i);
                var value = aspect.Value;

                if(text.length(value) == 0)
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
            => EmitFormDetails(FormDetailImportPath());

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

        public FS.FilePath EmitSymIndex()
        {
            var dst = SymbolImportPath();
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

        public Symbols<AttributeKind> AttributeKinds()
            => Symbols.index<AttributeKind>();

        public Symbols<Category> Categories()
            => Symbols.index<Category>();

        public Symbols<IClass> IClasses()
            => Symbols.index<IClass>();

        public Symbols<IFormType> IFormTypes()
            => Symbols.index<IFormType>();


        public void EmitSymCatalog()
        {
            EmitSymIndex();
            EmitSymbols<AddressWidth>();
            EmitSymbols<AttributeKind>();
            EmitSymbols<Category>();
            EmitSymbols<ChipCode>();
            EmitSymbols<CpuidBit>();
            EmitSymbols<EASZ>();
            EmitSymbols<EFlag>();
            EmitSymbols<EncodingGroup>();
            EmitSymbols<EOSZ>();
            EmitSymbols<Extension>();
            EmitSymbols<FlagAction>();
            EmitSymbols<IClass>();
            EmitSymbols<IFormType>();
            EmitSymbols<IsaKind>();
            EmitSymbols<Mode>();
            EmitSymbols<MachineMode>();
            EmitSymbols<Nonterminal>();
            EmitSymbols<OpCodeMap>();
            EmitSymbols<OperandAction>();
            EmitSymbols<OperandCategory>();
            EmitSymbols<OperandTypeKind>();
            EmitSymbols<OperandKind>();
            EmitSymbols<OperandVisibility>();
            EmitSymbols<OperandWidthType>();
            EmitSymbols<PointerWidth>();
            EmitSymbols<RegClassCode>();
            EmitSymbols<RegId>();
            EmitSymbols<RegRole>();
            EmitSymbols<SAMode>();
            EmitSymbols<SizeIndicator>();
        }

        FS.FilePath SummarySourcePath()
            => SourceDir() + FS.file("xed-idata", FS.Txt);

        public void ImportFormSummaries()
        {
            var parser = XedFormSummaryParser.create(Wf.EventSink);
            var parsed = parser.ParseSummaries(SummarySourcePath());
            var dst = Db.CatalogTable<XedFormInfo>("asm", "xed");
            ImportFormSummaries(parsed,dst);
        }

        public void ImportFormSummaries(FS.FilePath src, FS.FilePath dst)
        {
            var parser = XedFormSummaryParser.create(Wf.EventSink);
            var parsed = parser.ParseSummaries(src);
            ImportFormSummaries(parsed,dst);
        }

        public void ImportFormSummaries(ReadOnlySpan<XedFormInfo> src, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<XedFormInfo>(dst);
            var count = Tables.emit(src,dst,XedFormInfo.RenderWidths);
            Wf.EmittedTable(flow,count);
        }

        public Index<XedFormInfo> LoadFormSummaries()
        {
            var src = SummarySourcePath();
            var flow = Wf.Running("Loading xed instruction summaries");
            using var reader = src.Utf8Reader();
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
            var dst = ImportPath(FS.file(string.Format("{0}.{1}", dataset,  typeof(K).Name.ToLower()), FS.Csv));
            EmitSymbols(Symbols.index<K>().View, dst);
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
            return count != 0 ? parts.Select(ParseAttribute).ToArray() : array<AttributeKind>();
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

        public ReadOnlySpan<XedSummaryRow> LoadSummaries()
            => LoadSummaries(SummaryTarget());

        public ReadOnlySpan<XedSummaryRow> LoadSummaries(FS.FilePath src)
        {
            var flow  = Wf.Running(string.Format("Loading summary records from {0}", src.ToUri()));
            var doc = TextGrids.parse(src).Require();
            var count = doc.RowCount;
            var buffer = alloc<XedSummaryRow>(count);
            if(count != 0)
            {
                ref var dst = ref first(buffer);
                for(var i=0; i<count; i++)
                    LoadSummaryRow(doc[i], ref seek(dst, i));
            }

            Wf.Ran(flow, string.Format("Loaded {0} records from {1}", count, src.ToUri()));
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

        FS.FolderPath ImportDir()
           => Workspace.ImportDir(dataset);

        FS.FolderPath SourceDir()
           => Workspace.DataSource(dataset);

        FS.FilePath XedTableSourcePath()
            => SourceDir() + FS.file("xed-tables", FS.Txt);

        FS.FilePath ChipSourcePath()
            =>  SourceDir() + FS.file("xed-cdata", FS.Txt);

        FS.FilePath ChipMapImportPath()
            => Workspace.ImportDir(dataset) + FS.file("xed.chip-map", FS.Csv);

        FS.FilePath ImportPath(FS.FileName file)
             => ImportDir() + file;

        FS.FilePath FormDetailImportPath()
            => ImportDir() + FS.file("xed.forms.details", FS.Csv);

        FS.FilePath SymbolImportPath()
            => ImportDir() + FS.file("xed.symbols", FS.Csv);

        FS.FilePath FormAspectImportPath()
            => Workspace.ImportTable<XedFormAspect>("xed");

        FS.FolderPath TargetDir()
            => Workspace.ImportDir("xed.rules");

        FS.FilePath InstructionTarget(FS.FileName file)
            => TargetDir()  + FS.folder("instructions") + file;

        FS.FilePath MnemonicTarget()
            => TargetDir() + FS.file("mnemonics", FS.Csv);

        FS.FolderPath RuleTarget()
            => TargetDir() + FS.folder("rules");

        FS.FilePath FunctionTarget()
            => TargetDir() + FS.file("functions", FS.Txt);

        FS.FilePath SummaryTarget()
            => TargetDir() + FS.file("summary", FS.Csv);

        const char CommentMarker = Chars.Hash;

        const char FieldDelimiter = Chars.Space;

        static bool LoadSummaryRow(in TextRow src, ref XedSummaryRow dst)
        {
            if(src.CellCount == 10)
            {
                var i=0;
                dst.Class = src[i++];
                dst.Category = src[i++];
                dst.Extension = src[i++];
                dst.IsaSet = src[i++];
                dst.IForm = src[i++];
                dst.BaseCode = HexByteParser.Service.ParseData(src[i++]).Value ?? BinaryCode.Empty;
                dst.Mod = src[i++];
                dst.Reg = src[i++];
                dst.Pattern = src[i++];
                dst.Operands = src[i++];
                return true;
            }

            return false;
        }

        [Op]
        internal static XedPattern[] sort(XedPattern[] src)
            => (src as IEnumerable<XedPattern>).OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).Array();

        [Op]
        static XedSummaryRow BuildSummaryRow(in XedPattern src)
        {
            var modidx = src.Parts.TryFind(x => x.StartsWith(MODIDX)).MapValueOrDefault(x => x.RightOfFirst(ASSIGN).Trim(), EmptyString);
            var dst = new XedSummaryRow();
            dst.Class = src.Class;
            dst.Category = src.Category;
            dst.Extension = src.Extension;
            dst.IsaSet = src.IsaSet;
            dst.IForm = src.IForm;
            dst.BaseCode = XedParser.code(src);
            dst.Mod = XedParser.mod(src);
            dst.Reg = XedParser.reg(src);
            dst.Pattern = src.PatternText;
            dst.Operands = src.OperandText;
            return dst;
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

        XedSummaryRow[] EmitSummaries(XedPattern[] src)
        {
            var records = sort(src).Map(p => BuildSummaryRow(p));
            var target = SummaryTarget();
            Tables.emit(@readonly(records), target);
            return records;
        }

        Index<XedPattern> EmitInstructionPatterns()
        {
            var patterns = list<XedPattern>();
            var parser = XedParser.Service;
            var files = Source.InstructionFiles.View;
            var count = files.Length;
            for(var i=0; i<count; i++)
                EmitInstructionPatterns(skip(files,i), patterns);

            return patterns.ToArray();
        }

        void EmitInstructionPatterns(FS.FilePath dst, List<XedPattern> patterns)
        {
            var parser = XedParser.Service;
            var flow = Wf.EmittingFile(dst);
            var parsed = parser.ParseInstructions(dst);
            var count = parsed.Length;
            for(var j = 0; j<count; j++)
            {
                ref readonly var doc = ref skip(parsed, j);
                EmitInstructionPatterns(parsed, InstructionTarget(dst.FileName));
                patterns.AddRange(XedParser.patterns(doc, out _));
            }
            Wf.EmittedFile(flow, count);
        }

        [Op]
        void EmitInstructionPatterns(ReadOnlySpan<XedInstructionDoc> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            for(var i=0; i<src.Length; i++)
            {
                var rows = src[i];
                for(var j = 0; j < rows.RowCount; j++)
                    writer.WriteLine(rows[j].RowText);
                if(i != src.Length - 1)
                    writer.WriteLine(Separator);
            }
        }

        [Op]
        void EmitRules()
        {
            var parser = XedParser.Service;
            var sources = Source.FunctionFiles.View;
            var count = sources.Length;
            var ruleDir = RuleTarget();
            using var writer = FunctionTarget().Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var src = ref skip(sources,i);
                var functions = parser.ParseFunctions(src);
                if(functions.Length != 0)
                {
                    EmitFunctions(functions, writer);
                    EmitRulesets(functions, ruleDir);
                }
            }
        }

        [Op]
        void EmitRulesets(ReadOnlySpan<XedRuleSet> src, FS.FolderPath dir)
        {
            var count = src.Length;
            if(count == 0)
                return;

            var dst = dir + first(src).SourceFile;
            var emitting = Wf.EmittingFile(dst);
            using var writer = dst.Writer();

            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                if(i != 0)
                    writer.WriteLine();

                counter += EmitRuleset(skip(src,i), writer);
            }

            Wf.EmittedFile(emitting, counter);
        }

        [Op]
        void EmitFunctions(ReadOnlySpan<XedRuleSet> src, StreamWriter writer)
        {
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var f = ref skip(src,i);
                var body = f.Terms;
                if(body.Length != 0)
                {
                    writer.WriteLine(f.Description);
                    writer.WriteLine(Separator);

                    for(var j = 0; j <body.Length; j++)
                        writer.WriteLine(body[j]);

                    if(i != src.Length - 1)
                        writer.WriteLine();
                }
            }
        }

        static RenderPattern<object,object> IMPLY => "{0} -> {1}";

        static RenderPattern<object,object> OR => "{0} | {1}";

        [Op]
        uint EmitRuleset(in XedRuleSet ruleset, StreamWriter writer)
        {
            var content = ruleset.Terms.View;
            var kTerms = (uint)content.Length;

            if(kTerms != 0)
            {
                writer.WriteLine(ruleset.Description);
                for(var k=0; k<kTerms; k++)
                {
                    var line = skip(content, k).Format();
                    if(line.Contains(IMPLIES))
                    {
                        var left = line.LeftOfFirst(IMPLIES);
                        var opcount = SourceParser.ParseOperands(left, out var _operands);
                        var lhs = RP.parenthetical(opcount != 0 ? _operands.Intersperse(", ").Concat() : left);
                        var rhs = line.RightOfFirst(IMPLIES);
                        writer.WriteLine(IMPLY.Format(lhs,rhs));
                    }
                    else if(line.Contains(Bar))
                    {
                        var left = line.LeftOfFirst(Bar);
                        var opcount = SourceParser.ParseOperands(left, out var _operands);
                        var lhs = RP.parenthetical(opcount != 0 ? _operands.Intersperse(", ").Concat() : left);
                        var rhs = line.RightOfFirst(Bar);
                        writer.WriteLine(OR.Format(lhs,rhs));
                    }
                    else if(line.Contains(SEQUENCE))
                    {
                        var name = line.RightOfFirst(SEQUENCE);
                        writer.WriteLine($"{SEQUENCE}: {name}");
                        writer.WriteLine(Separator);
                        var i=0;
                        while(k < kTerms - 1)
                        {
                            line = skip(content, ++k).Format().Trim();
                            if(blank(line))
                                break;

                            writer.WriteLine(string.Format("{0,-2}: {1}", i++, line));
                        }

                        writer.WriteLine();
                    }
                    else
                        writer.WriteLine(line + " >.<");
                }
            }
            return kTerms;
        }

        void EmitMnemonics(XedSummaryRow[] src)
        {
            var upper = src.Select(s => s.Class).Distinct().OrderBy(x => x).ToArray();
            MnemonicTarget().Overwrite(upper);
        }
    }
}
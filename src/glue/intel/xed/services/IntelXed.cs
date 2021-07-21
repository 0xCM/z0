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
            var dir = Workspace.ImportRoot() + FS.folder("intel.xed");
            //ImportFormSummaries();
            EmitChipMap(dir);
            ImportForms(dir);
            EmitSymCatalog(dir);
            var aspects = EmitFormAspects(dir);
            var partition = Partition(aspects);
        }

        public void EmitTables(FS.FolderPath dst)
        {
            EmitChipMap(dst);
            ImportForms(dst);
            EmitSymCatalog(dst);
            var aspects = EmitFormAspects(dst);
            EmitPartitions(Partition(aspects), dst);
        }

        void EmitPartitions(ReadOnlySpan<FormPartition> src, FS.FolderPath dst)
        {
            var path = Tables.path<FormPartition>(dst);
            var flow = EmittingTable<FormPartition>(path);
            var count = Tables.emit(src, path, FormPartition.RenderWidths);
            EmittedTable(flow,count);
        }

        public ReadOnlySpan<string> MnemonicNames()
            => IClasses().Storage.Select(x => x.Expr.Text).ToArray();

        public Outcome LoadChipMap(out ChipMap dst)
            => ChipIsaParser.Parse(ChipSourcePath(), out dst);

        public Outcome EmitChipMap(FS.FolderPath dir)
        {
            const string RowFormat = "{0,-12} | {1,-24} | {2}";

            var outcome = LoadChipMap(out var map);
            if(outcome.Fail)
                Error(outcome.Message);
            else
            {
                var dst = ChipMapTablePath(dir);
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

        public ReadOnlySpan<FormPartition> Partition(Index<XedFormAspect> src)
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

        public Index<XedFormAspect> EmitFormAspects(FS.FolderPath dir)
        {
            var duplicates = dict<Hash32,uint>();
            var aspects = ComputeFormAspects();
            var count = (uint)aspects.Length;
            var buffer = alloc<XedFormAspect>(count);
            var dst = FormAspectImportPath(dir);
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
            var types = Symbols.index<IFormType>();
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

        public ReadOnlySpan<XedFormImport> EmitFormDetails()
            => EmitFormDetails(Workspace.ImportTable<XedFormImport>());

        public ReadOnlySpan<XedFormImport> EmitFormDetails(FS.FilePath dst)
        {
            var src = LoadImportedForms();
            var count = src.Length;
            var flow = Wf.EmittingFile(dst);
            Tables.emit(src, dst, XedFormImport.RenderWidths);
            Wf.EmittedFile(flow, count);
            return src;
        }

        public Index<SymLiteral> SymLiterals()
        {
            var src = typeof(XedModels).GetNestedTypes().Enums();
            return Symbols.literals(src);
        }

        public FS.FilePath EmitSymIndex(FS.FolderPath dir)
        {
            var dst = SymbolImportPath(dir);
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

        public Symbols<IClass> IClasses()
            => Symbols.index<IClass>();

        public void EmitSymCatalog(FS.FolderPath dir)
        {
            EmitSymIndex(dir);
            EmitSymbols<AddressWidth>(dir);
            EmitSymbols<AttributeKind>(dir);
            EmitSymbols<Category>(dir);
            EmitSymbols<ChipCode>(dir);
            EmitSymbols<CpuidBit>(dir);
            EmitSymbols<EASZ>(dir);
            EmitSymbols<EFlag>(dir);
            EmitSymbols<EncodingGroup>(dir);
            EmitSymbols<EOSZ>(dir);
            EmitSymbols<Extension>(dir);
            EmitSymbols<FlagAction>(dir);
            EmitSymbols<IClass>(dir);
            EmitSymbols<IFormType>(dir);
            EmitSymbols<IsaKind>(dir);
            EmitSymbols<Mode>(dir);
            EmitSymbols<MachineModeKind>(dir);
            EmitSymbols<Nonterminal>(dir);
            EmitSymbols<OpCodeMap>(dir);
            EmitSymbols<OperandAction>(dir);
            EmitSymbols<OperandCategory>(dir);
            EmitSymbols<OperandTypeKind>(dir);
            EmitSymbols<OperandKind>(dir);
            EmitSymbols<OperandVisibility>(dir);
            EmitSymbols<OperandWidthType>(dir);
            EmitSymbols<PointerWidth>(dir);
            EmitSymbols<RegClassCode>(dir);
            EmitSymbols<RegId>(dir);
            EmitSymbols<RegRole>(dir);
            EmitSymbols<SAMode>(dir);
            EmitSymbols<SizeIndicator>(dir);
        }

        public ReadOnlySpan<XedFormImport> ImportForms(FS.FolderPath dir)
        {
            var src = LoadFormSources().View;
            var dst = dir + FS.file(Tables.identify<XedFormImport>().Format(), FS.Csv);
            var flow = Wf.EmittingTable<XedFormImport>(dst);
            var parser = XedFormImportParser.create();
            var formatter = Tables.formatter<XedFormImport>(XedFormImport.RenderWidths);
            var count = src.Length;
            var result = Outcome.Success;
            var rows = list<XedFormImport>();
            using var writer = dst.Writer();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=z16; i<count; i++)
            {
                result = parser.Parse(skip(src,i), i, out var import);
                if(result)
                {
                    import.Index = i;
                    writer.WriteLine(formatter.Format(import));
                    rows.Add(import);
                }
                else
                {
                    Error(result.Message);
                    break;
                }
            }

            return result ? rows.ViewDeposited() : default;
        }

        public ReadOnlySpan<XedFormImport> LoadImportedForms()
        {
            var parser = XedFormImportParser.create();
            var src = Workspace.ImportTable<XedFormImport>();
            var counter = 0u;
            var outcome = Outcome.Success;
            var dst = list<XedFormImport>();
            using var reader = src.Utf8Reader();
            reader.ReadLine();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine(counter);

                if(line.StartsWith(CommentMarker))
                    continue;

                if(line.IsEmpty)
                    continue;

                outcome = parser.ParseRow(line, out var row);
                if(outcome)
                {
                    dst.Add(row);
                }
                else
                {
                    Wf.Error(outcome.Message);
                    break;
                }

                counter++;
            }
            if(outcome)
                return dst.ViewDeposited();
            else
                return default;
        }

        public Index<XedFormSource> LoadFormSources()
        {
            var src = FormSourcePath();
            var flow = Wf.Running("Loading xed instruction summaries");
            using var reader = src.Utf8Reader();
            var counter = 0u;
            var header = alloc<string>(XedFormSource.FieldCount);
            var succeeded = true;
            var records = list<XedFormSource>();
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
                   var dst = new XedFormSource();
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

        void EmitSymbols<K>(FS.FolderPath dir)
            where K : unmanaged, Enum
        {
            var name = string.Format("{0}.{1}", dataset, typeof(K).Name.ToLower());
            var symbols = Symbols.index<K>().View;
            var path = dir + FS.file(name,FS.Csv);
            EmitSymbols(symbols, path);
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

        public ReadOnlySpan<FormPartition> ComputePartitions()
        {
            var types  = Symbols.index<IFormType>();
            var classes = Symbols.index<IClass>();
            var count = types.Count;
            var buffer = alloc<FormPartition>(count);
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

        void Partition(in Symbols<IClass> classes, ushort index, IFormType src, ref FormPartition dst)
        {
            dst.Index = index;
            dst.Form = src;
            dst.Aspects = array<string>();
            var candidates = span(src.ToString().Split(Chars.Underscore));
            if(candidates.Length <= 1)
                return;
            dst.Aspects = slice(candidates,1).ToArray();
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

        static Outcome ParseSummary(TextLine src, out XedFormSource dst)
        {
            dst = default;
            var parts = src.Split(FieldDelimiter);
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
            var parts = src.Split(FieldDelimiter);
            var count = parts.Length;
            if(count != XedFormSource.FieldCount)
                return(false, $"Line splits into {count} parts, not {XedFormSource.FieldCount} as required");

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

        FS.FilePath FormSourcePath()
            => SourceDir() + FS.file("xed-idata", FS.Txt);

        FS.FolderPath SourceDir()
           => Workspace.DataSource(dataset);

        FS.FilePath XedTableSourcePath()
            => SourceDir() + FS.file("xed-tables", FS.Txt);

        FS.FilePath ChipSourcePath()
            =>  SourceDir() + FS.file("xed-cdata", FS.Txt);

        FS.FilePath ChipMapTablePath(FS.FolderPath dir)
            => dir + FS.file("xed.chip-map", FS.Csv);

        FS.FilePath SymbolImportPath(FS.FolderPath dir)
            => dir + FS.file("xed.symbols", FS.Csv);

        FS.FilePath FormAspectImportPath(FS.FolderPath dir)
            => dir + FS.file(Tables.identify<XedFormAspect>().Format(),FS.Csv);

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
    }
}
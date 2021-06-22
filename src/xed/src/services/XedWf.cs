//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    using static Root;
    using static core;
    using static XedSourceMarkers;

    [ApiHost]
    public ref struct XedWf
    {
        public static XedWf create(IWfRuntime wf)
            => new XedWf(wf,new XedWfConfig(wf));

        readonly XedWfConfig Config;

        readonly IWfRuntime Wf;

        readonly XedDataSource Source;

        readonly ITableArchive Target;

        const string Subject = "xed";

        readonly FS.FolderPath Root;

        readonly XedParser SourceParser;

        public XedWf(IWfRuntime wf, XedWfConfig config)
        {
            Wf = wf;
            Config = config;
            Source = new XedDataSource(Config.Source);
            var db = Wf.Db();
            Target = new DbTables<string>(db, Subject);
            Root = Target.Root;
            SourceParser = XedParser.Service;
        }

        public void Dispose()
        {

        }

        public void Run()
        {
            Root.Clear(true);
            var patterns = EmitInstructionPatterns();
            var summaries = EmitSummaries(patterns);
            EmitMnemonics(summaries);
            EmitRules();
        }

        public Index<XedSummaryRow> LoadSummaries()
            => LoadSummaries(SummaryPath);

        public Index<XedSummaryRow> LoadSummaries(FS.FilePath src)
        {
            var flow  = Wf.Running(string.Format("Loading summary records from {0}", src.ToUri()));
            var doc = TextGrids.parse(src).Require();
            var count = doc.RowCount;
            var buffer = sys.alloc<XedSummaryRow>(count);
            if(count != 0)
            {
                ref var dst = ref first(buffer);
                for(var i=0; i<count; i++)
                    LoadSummaryRow(doc[i], ref seek(dst, i));
            }

            Wf.Ran(flow, string.Format("Loaded {0} records from {1}", count, src.ToUri()));
            return buffer;
        }

        [Op]
        internal static XedPattern[] sort(XedPattern[] src)
            => (src as IEnumerable<XedPattern>).OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).Array();

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

        FS.FilePath SummaryPath => Root + FS.file("summary", FS.Csv);

        XedSummaryRow[] EmitSummaries(XedPattern[] src)
        {
            var records = sort(src).Map(p => BuildSummaryRow(p));
            var target = SummaryPath;
            Tables.emit(@readonly(records), target);
            return records;
        }

        Index<XedPattern> EmitInstructionPatterns()
        {
            var patterns = root.list<XedPattern>();
            var parser = XedParser.Service;
            var files = Source.InstructionFiles.View;
            var count = files.Length;
            for(var i=0; i<count; i++)
                patterns.AddRange(EmitInstructionPatterns(skip(files,i)));

            return patterns.ToArray();
        }

        Index<XedPattern> EmitInstructionPatterns(FS.FilePath dst)
        {
            var patterns = root.list<XedPattern>();
            var parser = XedParser.Service;
            var flow = Wf.EmittingFile(dst);
            var parsed = span(parser.ParseInstructions(dst));
            for(var j = 0; j<parsed.Length; j++)
            {
                ref readonly var doc = ref skip(parsed, j);
                EmitInstructionPatterns(parsed, Config.InstructionDir + dst.FileName);
                patterns.AddRange(XedParser.patterns(doc, out _));
            }
            Wf.EmittedFile(flow, parsed.Length);
            return patterns.ToArray();
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
            var kSrc = sources.Length;

            var ruleDir = Config.Target + FS.folder("rules");
            var funcpath = Config.Target + FS.file("functions", FS.Txt);
            using var funcwriter = funcpath.Writer();

            for(var i=0; i<kSrc; i++)
            {
                ref readonly var src = ref skip(sources,i);
                var functions = parser.ParseFunctions(src);
                if(functions.Length != 0)
                {
                    EmitFunctions(functions, funcwriter);
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
                ref readonly var f = ref src[i];
                var body = f.Terms;
                if(body.Length != 0)
                {
                    writer.WriteLine(f.Description);
                    writer.WriteLine(Separator);

                    for(var j = 0; j < body.Length; j++)
                        writer.WriteLine(body[j]);

                    if(i != src.Length - 1)
                        writer.WriteLine();
                }
            }
        }

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
                        writer.WriteLine(string.Format("{0} -> {1}", lhs, rhs));
                    }
                    else if(line.Contains(Bar))
                    {
                        var left = line.LeftOfFirst(Bar);
                        var opcount = SourceParser.ParseOperands(left, out var _operands);
                        var lhs = RP.parenthetical(opcount != 0 ? _operands.Intersperse(", ").Concat() : left);
                        var rhs = line.RightOfFirst(Bar);
                        writer.WriteLine(string.Format("{0} | {1}", lhs, rhs));
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
                            if(text.blank(line))
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
            var dst = Target.TablePath(FS.file("mnemonics", FS.Csv));
            dst.Overwrite(upper);
        }
    }
}
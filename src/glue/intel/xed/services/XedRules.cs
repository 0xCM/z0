//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using Z0.Asm;

    using static Root;
    using static core;
    using static XedSourceMarkers;

    [ApiHost]
    public class XedRules : AppService<XedRules>
    {
        AsmWorkspace Workspace;

        XedDataSource Source;

        const string dataset = "xed.rules";

        XedParser SourceParser;

        protected override void Initialized()
        {
            Workspace = Wf.AsmWorkspace();
            Source = new XedDataSource(Workspace.DataSource(dataset));
            SourceParser = XedParser.Service;
        }

        FS.FolderPath TargetDir()
            => Workspace.ImportDir(dataset);

        public void Import()
        {
            //Root.Clear(true);
            var patterns = EmitInstructionPatterns();
            var summaries = EmitSummaries(patterns);
            EmitMnemonics(summaries);
            EmitRules();
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
                patterns.AddRange(EmitInstructionPatterns(skip(files,i)));

            return patterns.ToArray();
        }

        Index<XedPattern> EmitInstructionPatterns(FS.FilePath dst)
        {
            var patterns = list<XedPattern>();
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
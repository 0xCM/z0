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

    using static Part;
    using static memory;
    using static XedSourceMarkers;

    [ApiHost]
    readonly partial struct Xed
    {
        [Op]
        public static XedPattern[] sort(XedPattern[] src)
            => (src as IEnumerable<XedPattern>).OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).Array();

        [Op]
        public static FS.FileName rulefile(FS.FileName src, string name)
            => FS.file(text.format("{0}.{1}.{2}.{3}", "xed", "rules", src.WithoutExtension, name), FileExtensions.Csv);

        [Op]
        public static XedPatternRow[] filter(XedPatternRow[] src, XedExtension match)
            => src.Where(p => p.Extension  == XedConst.Name(match));

        [Op]
        public static XedPatternRow[] filter(XedPatternRow[] src, XedCategory match)
            => src.Where(p => p.Category == XedConst.Name(match));

        [Op]
        public static string pattern(XedInstructionDoc src, string name)
        {
            for(var i=0; i<src.RowCount; i++)
            {
                var row = src.Content[i];
                var rowText = row.Text;
                if(text.nonempty(rowText) && rowText.StartsWith(name))
                {
                    var value = rowText.RightOfFirst(PROP_DELIMITER);
                    if(text.nonempty(value))
                        return value.Trim();
                }
            }
            return EmptyString;
        }

        [Op]
        public static ref XedPattern pattern(in XedInstructionDoc src, int index, ref XedPattern dst)
        {
            dst.Class = src.Class ?? string.Empty;
            dst.Category = src.Category ?? string.Empty;
            dst.Extension = src.Extension ?? string.Empty;
            dst.IsaSet = src.IsaSet ?? string.Empty;
            var patternText = src.ExtractProp(index);
            var operandText = src.ExtractProp(index + 1);
            dst.PatternText = patternText ?? string.Empty;
            dst.Parts = patternText.SplitClean(Space);
            dst.OperandText = operandText ?? string.Empty;
            dst.Operands = operandText.SplitClean(Space);
            return ref dst;
        }

        [Op]
        public static XedPattern[] patterns(in XedInstructionDoc src)
            => patterns(src, out var _);

        [Op]
        public static ref XedPattern[] patterns(in XedInstructionDoc src, out XedPattern[] dst)
        {
            var patterns = z.list<XedPattern>();
            var count = src.RowCount;
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                if(src.IsProp(i, PATTERN) && i != last)
                {
                    if(src.IsProp(i + 1, OPERANDS))
                    {
                        var pattern = new XedPattern();
                        Xed.pattern(src, i, ref pattern);
                        patterns.Add(pattern);
                    }
                }
            }
            dst = patterns.ToArray();
            return ref dst;
        }


        [MethodImpl(Inline), Op]
        public static RuleOperand operand(string name, string value)
            => new RuleOperand(name, value);

        [MethodImpl(Inline), Op]
        public static RuleOperand operand(string value)
            => new RuleOperand(value);

        [Op]
        public static void emit(ReadOnlySpan<XedRuleSet> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            Xed.emit(src, writer);
        }

        [Op]
        public static void emit(ReadOnlySpan<XedInstructionDoc> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            for(var i=0; i<src.Length; i++)
            {
                var rows = src[i];
                for(var j = 0; j < rows.RowCount; j++)
                    writer.WriteLine(rows[j].Text);
                if(i != src.Length - 1)
                    writer.WriteLine(Separator);
            }
        }

        [Op]
        public static void emit(IWfShell wf, in XedWfConfig config, in XedSources xs)
        {
            var parser = XedSourceParser.Service;
            var sources = xs.FunctionFiles.View;
            var kSrc = sources.Length;

            var rulepath = config.Target + FS.file("rules", FileExtensions.Txt);
            var funcpath = config.Target + FS.file("functions", FileExtensions.Txt);
            using var rulewriter = rulepath.Writer();
            using var funcwriter = funcpath.Writer();

            for(var i=0; i<kSrc; i++)
            {
                ref readonly var src = ref skip(sources,i);
                var functions = parser.ParseFunctions(src);
                var kFunc = functions.Length;
                if(kFunc != 0)
                {
                    emit(functions, funcwriter);

                    var view = @readonly(functions);
                    for(var j=0; j<kFunc; j++)
                    {
                        ref readonly var ruleset = ref skip(view,j);
                        emit(skip(view,j), rulewriter);
                        wf.Status($"Emitted ruleset {ruleset.Name}");
                    }
                }
            }
        }

        [Op]
        public static void emit(ReadOnlySpan<XedRuleSet> src, StreamWriter writer)
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
        public static void emit(in XedRuleSet ruleset, StreamWriter writer)
        {
            var content = ruleset.Terms.View;
            var kTerms = content.Length;

            if(kTerms != 0)
            {
                writer.WriteLine(ruleset.Description);
                writer.WriteLine(Separator);
                for(var k=0; k<kTerms; k++)
                {
                    var line = skip(content, k).Format();
                    if(line.Contains(IMPLIES))
                    {
                        var left = line.LeftOfFirst(IMPLIES);
                        var operands = left.SplitClean(Chars.Space);
                        var lhs = text.parenthetical(operands.Length != 0 ? operands.Intersperse(", ").Concat() : left);
                        var rhs = line.RightOfFirst(IMPLIES);
                        writer.WriteLine(string.Format("{0} => {1}", lhs, rhs));
                    }
                    else if(line.Contains(PRODUCTION))
                    {
                        var left = line.LeftOfFirst(PRODUCTION);
                        var operands = left.SplitClean(Chars.Space);
                        var lhs = text.parenthetical(operands.Length != 0 ? operands.Intersperse(", ").Concat() : left);
                        var rhs = line.RightOfFirst(PRODUCTION);
                        writer.WriteLine(string.Format("{0} => {1}", lhs, rhs));
                    }
                    else
                        writer.WriteLine(line + " => ?");
                }
                writer.WriteLine(RP.PageBreak120);
            }
        }

        [MethodImpl(Inline), Op]
        public static XedSources sources(FS.FolderPath root)
            => new XedSources(root);

        [Op]
        public static string reg(XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(REG)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), EmptyString);

        [Op]
        public static TextBlock mod(XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(MOD)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), EmptyString);

        [Op]
        public static BinaryCode code(XedPattern src)
        {
            var dst = 0ul;
            var pos = 0u;
            var count = src.Parts.Length;
            var parser = HexByteParser.Service;
            for(var i=0u; i<count; i++)
            {
                var part = src.Parts[i];
                if(parser.HasPreSpec(part))
                    seek8(dst, pos++) = parser.ParseByte(part);
            }

            return slice(ByteRead.read8(dst), 0, pos);
        }

        [Op]
        public static TextBlock basecode(XedPattern src)
        {
            var dst = text.build();
            var count = src.Parts.Length;
            for(var i=0; i<count; i++)
            {
                var part = src.Parts[i];
                dst.Append(part);
                if(i != count - 1)
                    dst.Append(Chars.Space);
            }

            return dst.ToString();
        }
    }
}
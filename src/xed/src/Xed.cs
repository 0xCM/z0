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

    using F = XedSummaryField;

    [ApiHost]
    public readonly partial struct Xed
    {
        [Op]
        public static Index<XedSummaryRow> summaries(ITableArchive archive)
        {
            var src = archive.TablePath(FS.file(XedSummaryRow.TableId, FileExtensions.Csv));
            var doc = archive.Document(src).Require();
            var count = doc.RowCount;
            var buffer = sys.alloc<XedSummaryRow>(count);
            if(count != 0)
            {
                ref var dst = ref first(buffer);
                for(var i=0; i<count; i++)
                    load(doc[i], ref seek(dst, i));
            }

            return buffer;
        }

        [Op]
        public static string format(in XedPattern src, char delimiter)
        {
            var dst = Table.formatter<XedSummaryField>(delimiter);
            render(src,dst);
            return dst.Format();
        }

        [Op]
        public static string format(in XedSummaryRow src, char delimiter)
        {
            var dst = Table.formatter<XedSummaryField>(delimiter);
            render(src, dst);
            return dst.Format();
        }

        [MethodImpl(Inline), Op]
        static ref readonly DatasetFieldFormatter<XedSummaryField> render(in XedPattern src, in DatasetFieldFormatter<XedSummaryField> dst)
        {
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, Xed.code(src));
            dst.Delimit(F.Mod, Xed.mod(src));
            dst.Delimit(F.Reg, Xed.reg(src));
            dst.Delimit(F.Pattern, src.PatternText);
            dst.Delimit(F.Operands, src.Operands);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        static ref readonly DatasetFieldFormatter<XedSummaryField> render(in XedSummaryRow src, in DatasetFieldFormatter<XedSummaryField> dst)
        {
            dst.Delimit(F.Class, src.Class);
            dst.Delimit(F.Category, src.Category);
            dst.Delimit(F.Extension, src.Extension);
            dst.Delimit(F.IsaSet, src.IsaSet);
            dst.Delimit(F.BaseCode, src.BaseCode);
            dst.Delimit(F.Mod, src.Mod);
            dst.Delimit(F.Reg, src.Reg);
            dst.Delimit(F.Pattern, src.Pattern);
            dst.Delimit(F.Operands, src.Operands);
            return ref dst;
        }

        [Op]
        static bool load(in TextRow src, ref XedSummaryRow dst)
        {
            if(src.BlockCount == 9)
            {
                var i=0;
                dst.Class = src[i++];
                dst.Category = src[i++];
                dst.Extension = src[i++];
                dst.IsaSet = src[i++];
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
        internal static XedSummaryRow row(in XedPattern src)
        {
            var modidx = src.Parts.TryFind(x => x.StartsWith(MODIDX)).MapValueOrDefault(x => x.RightOfFirst(ASSIGN).Trim(), EmptyString);
            var dst = new XedSummaryRow();
            dst.Class = src.Class;
            dst.Category = src.Category;
            dst.Extension =  src.Extension;
            dst.IsaSet =  src.IsaSet;
            dst.BaseCode =  Xed.code(src);
            dst.Mod =  Xed.mod(src);
            dst.Reg =  Xed.reg(src);
            dst.Pattern =  src.PatternText;
            dst.Operands =  src.OperandText;
            return dst;
        }

        [Op]
        internal static XedPattern[] sort(XedPattern[] src)
            => (src as IEnumerable<XedPattern>).OrderBy(x => x.Class).ThenBy(x => x.Category).ThenBy(x => x.Extension).ThenBy(x => x.IsaSet).Array();

        [Op]
        internal static FS.FileName rulefile(FS.FileName src, string name)
            => FS.file(text.format("{0}.{1}.{2}.{3}", "xed", "rules", src.WithoutExtension, name), FileExtensions.Csv);

        [Op]
        internal static XedSummaryRow[] filter(XedSummaryRow[] src, XedExtension match)
            => src.Where(p => p.Extension  == XedConst.Name(match));

        [Op]
        internal static XedSummaryRow[] filter(XedSummaryRow[] src, XedCategory match)
            => src.Where(p => p.Category == XedConst.Name(match));

        [Op]
        internal static string pattern(XedInstructionDoc src, string name)
        {
            for(var i=0; i<src.RowCount; i++)
            {
                var row = src.Content[i];
                var rowText = row.RowText;
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
        static ref XedPattern pattern(in XedInstructionDoc src, int index, ref XedPattern dst)
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
        static ref XedPattern[] patterns(in XedInstructionDoc src, out XedPattern[] dst)
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
        static RuleOperand operand(string value)
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
                    writer.WriteLine(rows[j].RowText);
                if(i != src.Length - 1)
                    writer.WriteLine(Separator);
            }
        }

        [Op]
        internal static void emit(IWfShell wf, in XedWfConfig config, in XedDataSource xs)
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
        internal static void emit(ReadOnlySpan<XedRuleSet> src, StreamWriter writer)
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

        static int operands(ReadOnlySpan<char> src, out Span<string> dst)
        {
            var operands = root.list<string>();
            var length = src.Length;
            var current = EmptyString;
            for(var i=0; i<length; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(Char.IsWhiteSpace(c))
                {
                    if(text.nonempty(current))
                    {
                        operands.Add(current);
                        current = EmptyString;
                    }
                }
                else
                    current += c;
            }

            if(text.nonempty(current))
                operands.Add(current);

            dst = operands.ToArray();
            return dst.Length;
        }

        [Op]
        internal static void emit(in XedRuleSet ruleset, StreamWriter writer)
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
                        var opcount = Xed.operands(left, out var _operands);
                        var lhs = text.parenthetical(opcount != 0 ? _operands.Intersperse(", ").Concat() : left);
                        var rhs = line.RightOfFirst(IMPLIES);
                        writer.WriteLine(string.Format("{0} -> {1}", lhs, rhs));
                    }
                    else if(line.Contains(Bar))
                    {
                        var left = line.LeftOfFirst(Bar);
                        var opcount = Xed.operands(left, out var _operands);
                        var lhs = text.parenthetical(opcount != 0 ? _operands.Intersperse(", ").Concat() : left);
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
                writer.WriteLine(RP.PageBreak120);
            }
        }

        [MethodImpl(Inline), Op]
        internal static XedDataSource sources(FS.FolderPath root)
            => new XedDataSource(root);

        [Op]
        internal static string reg(in XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(REG)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), EmptyString);

        [Op]
        internal static TextBlock mod(in XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(MOD)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), EmptyString);

        [Op]
        internal static BinaryCode code(in XedPattern src)
        {
            var dst = 0ul;
            var pos = 0u;
            var count = src.Parts.Length;
            var parser = HexByteParser.Service;
            for(var i=0u; i<count; i++)
            {
                var part = src.Parts[i];
                if(HexTest.HasPreSpec(part))
                    seek8(dst, pos++) = parser.ParseByte(part);
            }

            return slice(ByteReader.read8(dst), 0, pos);
        }

        [Op]
        internal static TextBlock basecode(in XedPattern src)
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
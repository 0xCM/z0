//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static XedSourceMarkers;

    using M = XedSourceMarkers;

    readonly struct XedParser
    {
        [MethodImpl(Inline)]
        static bool IsProp(in XedInstructionDoc src, int index, string Name)
            => src[index].RowText.StartsWith(Name);

        [MethodImpl(Inline)]
        internal static string ExtractProp(TextRow src)
            => src.RowText.RightOfFirst(M.PROP_DELIMITER).Trim();

        [MethodImpl(Inline)]
        internal static string ExtractProp(in XedInstructionDoc src, int index)
            => ExtractProp(src[index]);

        [Op]
        internal static FS.FileName rulefile(FS.FileName src, string name)
            => FS.file(text.format("{0}.{1}.{2}.{3}", "xed", "rules", src.WithoutExtension, name), FS.Txt);

        [Op]
        internal static string pattern(XedInstructionDoc src, string marker)
        {
            for(var i=0; i<src.RowCount; i++)
            {
                var rowData = src.Content[i];
                var rowText = rowData.RowText;
                if(text.nonempty(rowText) && rowText.StartsWith(marker))
                {
                    var value = rowText.RightOfFirst(PROP_DELIMITER);
                    if(text.nonempty(value))
                        return value.Trim();
                }
            }
            return EmptyString;
        }

        [Op]
        public static ref XedPattern[] patterns(in XedInstructionDoc src, out XedPattern[] dst)
        {
            var patterns = root.list<XedPattern>();
            var count = src.RowCount;
            var last = count - 1;
            for(var i=0; i<count; i++)
            {
                if(IsProp(src, i, PATTERN) && i != last)
                {
                    if(IsProp(src, i + 1, OPERANDS))
                    {
                        var pattern = new XedPattern();
                        XedParser.ParsePattern(src, i, ref pattern);
                        patterns.Add(pattern);
                    }
                }
            }
            dst = patterns.ToArray();
            return ref dst;
        }

        [Op]
        public static ref XedPattern ParsePattern(in XedInstructionDoc src, int row, ref XedPattern dst)
        {
            dst.Class = pattern(src, M.ICLASS);
            dst.Category = pattern(src, M.CATEGORY);
            dst.Extension = pattern(src, M.EXTENSION);
            dst.IsaSet = pattern(src, M.ISA_SET);
            dst.IForm = pattern(src, M.IFORM);
            var patternText = ExtractProp(src,row);
            var operandText = ExtractProp(src, row + 1);
            dst.PatternText = patternText ?? EmptyString;
            dst.Parts = patternText.SplitClean(Space);
            dst.OperandText = operandText ?? EmptyString;
            dst.Operands = operandText.SplitClean(Space);
            return ref dst;
        }

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
                if(HexFormatSpecs.HasPreSpec(part))
                    seek8(dst, pos++) = parser.ParseByte(part);
            }

            return slice(ByteReader.read8(dst), 0, pos);
        }

        [Op]
        public static string reg(in XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(REG)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), EmptyString);

        [Op]
        public static TextBlock mod(in XedPattern src)
            => src.Parts.TryFind(x => x.StartsWith(MOD)).MapValueOrDefault(x => x.Unfence(Chars.LBracket, Chars.RBracket), EmptyString);

        public static XedParser Service => default;

        public XedDocRows LoadSource(FS.FilePath src)
            => TextGrids.parse(src,TextDocFormat.Unstructured())
                    .MapValueOrDefault(c => new XedDocRows(src, c.RowData), XedDocRows.Empty);

        public int ParseOperands(ReadOnlySpan<char> src, out Span<string> dst)
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

        public XedInstructionDoc ParseInstruction(XedDocRows src, in int idxStart, ref int ix)
        {
            var rows = root.list<TextRow>();
            var parsing = false;
            var count = src.RowCount;
            for(var i = idxStart; i<count; i++, ix++)
            {
                var row = src[i];

                if(Skip(row))
                    continue;

                if(IsRightDelimiter(row))
                {   --ix;
                    break;
                }


                if(IsLeftDelimiter(row))
                    parsing = true;
                else if(parsing)
                    rows.Add(row);

            }
            return new XedInstructionDoc(rows.ToArray());
        }

        XedInstructionDoc[] ParseInstructions(XedDocRows data, int ix)
        {
            var dst = root.list<XedInstructionDoc>();
            for(var i=0; i<data.RowCount; i++)
            {
                var parsed = ParseInstruction(data, ++i, ref i);
                if(parsed.IsNonEmpty)
                    dst.Add(parsed);
            }
            return dst.ToArray();
        }

        public XedInstructionDoc[] ParseInstructions(FS.FilePath src)
        {
            var data = LoadSource(src);
            for(var i=0; i<data.RowCount; i++)
            {
                if(data[i].Format().ContainsAny(Instructions))
                    return ParseInstructions(data, i);
            }
            return memory.array<XedInstructionDoc>();
        }

        static void Advance(ref int index)
            => ++index;

        static void Retreat(ref int index)
            => --index;

        XedRuleSet ParseFunction(XedDocRows rows, ref int ix)
        {
            var title = rows[ix].RowText.LeftOfFirst(RuleMarker);
            var body = root.list<string>();
            var first = ix;
            for(var i = ix; i<rows.RowCount; i++)
            {
                ref readonly var row = ref rows[ix];
                var isHeader = Contains(row, RuleMarker);
                if(isHeader)
                {
                    if(i != first)
                    {
                        Retreat(ref ix);
                        break;
                    }
                    else
                    {
                        Advance(ref ix);
                        continue;
                    }
                }

                Advance(ref ix);

                if(IsComment(row))
                    continue;

                if(IsEmpty(row))
                    continue;

                body.Add(row.RowText);
            }

            var parts = title.SplitClean(Chars.Space);
            var rt = parts.Length == 2 ? parts[0] : string.Empty;
            var name = parts.Length == 1 ? parts[0] : (parts.Length == 2 ? parts[1] : EmptyString);
            var srcName = rows.Source.FileName;
            return new XedRuleSet(srcName, name, rt, body.Map(x => new XedExpr(x)), rulefile(srcName, name));
        }

        public XedRuleSet[] ParseFunctions(FS.FilePath src)
        {
            var dst = root.list<XedRuleSet>();
            var data = LoadSource(src);
            var count = data.RowCount;
            for(var i=0; i<count; i++)
            {
                var row = data[i];
                if(Contains(data[i], RuleMarker))
                    dst.Add(ParseFunction(data, ref i));
            }

            return dst.ToArray();
        }

        bool IsLeftDelimiter(TextRow src)
            => src.RowText.Contains(FuncBodyBegin);

        bool IsRightDelimiter(TextRow src)
            => src.RowText.Contains(FuncBodyEnd);

        bool IsComment(TextRow src)
            => src.RowText.StartsWith("#");

        bool IsEmpty(TextRow src)
            => text.blank(src.RowText);

        bool IsSeqHeader(TextRow src)
            => src.RowText.StartsWith(SEQUENCE);

        bool Contains(TextRow src, string substring)
            => src.RowText.ContainsAny(substring);

        bool Skip(TextRow src)
            => IsComment(src) || IsEmpty(src);
    }
}
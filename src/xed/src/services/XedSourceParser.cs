//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static XedSourceMarkers;

    readonly struct XedSourceParser
    {
        public static XedSourceParser Service => default;

        public XedDocRows LoadSource(FS.FilePath src)
            => TextDocs.parse(src,TextDocFormat.Unstructured())
                    .MapValueOrDefault(c => new XedDocRows(src, c.RowData), XedDocRows.Empty);

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
            return new XedRuleSet(srcName, name, rt, body.Map(x => new XedExpr(x)), XedApi.rulefile(srcName, name));
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
//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static XedSourceMarkers;

    readonly struct XedSourceParser
    {
        public static XedSourceParser Service => default;

        public TextDocRows LoadSource(FS.FilePath src)
            => TextDocParser.parse(src,TextDocFormat.Unstructured)
                    .MapValueOrDefault(c => new TextDocRows(src, c.RowData), TextDocRows.Empty);

        public XedInstructionDoc ParseInstruction(TextDocRows src, in int idxStart, ref int ix)
        {
            var rows = list<TextRow>();
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

        XedInstructionDoc[] ParseSequence(TextDocRows data, int ix)
        {
            var dst = list<XedInstructionDoc>();
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
                if(data[i].Text.ContainsAny(InstructionSeq))
                    return ParseSequence(data, i);
            }
            return z.array<XedInstructionDoc>();
        }

        static void Advance(ref int index)
            => ++index;

        static void Retreat(ref int index)
            => --index;

        XedRuleSet ParseFunction(TextDocRows data, ref int ix)
        {
            var title = data[ix].Text.LeftOf(RuleMarker);
            var body = list<string>();
            var first = ix;
            for(var i = ix; i<data.RowCount; i++)
            {
                ref readonly var row = ref data[ix];

                var isHeader = Contains(row,RuleMarker);
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

                body.Add(row.Text);

            }

            var parts = title.SplitClean(Chars.Space);
            var rt = parts.Length == 2 ? parts[0] : string.Empty;
            var name = parts.Length == 1 ? parts[0] : (parts.Length == 2 ? parts[1] : EmptyString);
            var srcName = data.Source.FileName;
            return new XedRuleSet(srcName, name, rt, body.Map(x => new XedRule(x)), XedOps.TargetRuleFile(srcName, name));
        }


        public XedRuleSet[] ParseFunctions(FS.FilePath src)
        {
            var dst = list<XedRuleSet>();
            var data = LoadSource(src);
            for(var i=0; i<data.RowCount; i++)
            {
                var row = data[i];
                if(Contains(data[i], RuleMarker))
                    dst.Add(ParseFunction(data, ref i));
            }

            return dst.ToArray();
        }

        bool IsLeftDelimiter(TextRow src)
            => src.Text.Contains(FuncBodyBegin);

        bool IsRightDelimiter(TextRow src)
            => src.Text.Contains(FuncBodyEnd);

        bool IsComment(TextRow src)
            => src.Text.StartsWith("#");

        bool IsEmpty(TextRow src)
            => text.blank(src.Text);

        bool Contains(TextRow src, string substring)
            => src.Text.ContainsAny(substring);

        bool Skip(TextRow src)
            => IsComment(src) || IsEmpty(src);
    }
}
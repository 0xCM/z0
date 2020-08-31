//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static XedSourceMarkers;

    readonly struct XedSourceParser
    {
        public static XedSourceParser Service => default;

        public TextFileRows LoadSource(FilePath src)
            => TextDocParser.parse(src,TextDocFormat.Unstructured)
                    .MapValueOrDefault(c => TextFileRows.define(src, c.RowData), TextFileRows.Empty);

        public XedInstructionData ParseInstruction(TextFileRows src, in int idxStart, ref int idxterm)
        {
            var rows = list<TextRow>();
            var parsing = false;
            for(var i = idxStart; i<src.RowCount;  i++, idxterm++)
            {
                var row = src[i];

                if(Skip(row))
                    continue;

                if(IsRightDelimiter(row))
                {   --idxterm;
                    break;
                }


                if(IsLeftDelimiter(row))
                    parsing = true;
                else if(parsing)
                    rows.Add(row);

            }
            return new XedInstructionData(rows.ToArray());
        }

        XedInstructionData[] ParseSequence(TextFileRows data, int idx)
        {
            var dst = list<XedInstructionData>();
            for(var i=0; i<data.RowCount; i++)
            {
                var parsed = ParseInstruction(data, ++i, ref i);
                if(parsed.IsNonEmpty)
                    dst.Add(parsed);
            }
            return dst.ToArray();
        }

        public XedInstructionData[] ParseInstructions(FilePath src)
        {
            var data = LoadSource(src);
            for(var i=0; i<data.RowCount; i++)
            {
                if(data[i].Text.ContainsAny(INSTRUCTION_SEQ))
                    return ParseSequence(data, i);
            }
            return Root.array<XedInstructionData>();
        }

        static void Advance(ref int rowidx)
            => ++rowidx;

        static void Retreat(ref int rowidx)
            => --rowidx;

        XedFunctionData ParseFunction(TextFileRows data, ref int rowidx)
        {
            var title = data[rowidx].Text.LeftOf(FUNC_MARKER);
            var body = list<string>();
            var first = rowidx;
            for(var i = rowidx; i<data.RowCount; i++)
            {
                ref readonly var row = ref data[rowidx];

                var isHeader = Contains(row,FUNC_MARKER);
                if(isHeader)
                {
                    if(i != first)
                    {
                        Retreat(ref rowidx);
                        break;
                    }
                    else
                    {
                        Advance(ref rowidx);
                        continue;
                    }
                }

                Advance(ref rowidx);

                if(IsComment(row))
                    continue;

                if(IsEmpty(row))
                    continue;

                body.Add(row.Text);

            }

            var parts = title.SplitClean(Chars.Space);
            var rt = parts.Length == 2 ? parts[0] : string.Empty;
            var name = parts.Length == 1 ? parts[0] : (parts.Length == 2 ? parts[1] : string.Empty);
            return new XedFunctionData(data.Source.FileName, name, rt, body.ToArray());
        }

        public XedFunctionData[] ParseFunctions(FilePath src)
        {
            var dst = list<XedFunctionData>();
            var data = LoadSource(src);
            for(var i=0; i<data.RowCount; i++)
            {
                var row = data[i];
                if(Contains(data[i], FUNC_MARKER))
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
//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static SourceMarkers;

    readonly struct SourceParser
    {
        public static SourceParser Service => default;

        public SourceFileData LoadSource(FilePath src)
            => TextDocParser.parse(src,TextDocFormat.Unstructured)
                   .MapValueOrDefault(c => SourceFileData.Define(src, c.RowData), SourceFileData.Empty);

        public InstructionData ParseInstruction(SourceFileData src, in int idxStart, ref int idxterm)
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
            return new InstructionData(rows.ToArray());
        }

        InstructionData[] ParseSequence(SourceFileData data, int idx)
        {
            var dst = list<InstructionData>();            
            for(var i=0; i<data.RowCount; i++)
            {
                var parsed = ParseInstruction(data, ++i, ref i);
                if(parsed.IsNonEmpty)
                    dst.Add(parsed);
            }
            return dst.ToArray();
        }

        public InstructionData[] ParseInstructions(FilePath src)
        {
            var data = LoadSource(src);
            for(var i=0; i<data.RowCount; i++)
            {
                if(data[i].Text.ContainsAny(INSTRUCTION_SEQ))  
                    return ParseSequence(data, i);
            }
            return Root.array<InstructionData>();
        }

        static void Advance(ref int rowidx)
            => ++rowidx;

        static void Retreat(ref int rowidx)
            => --rowidx;

        FunctionData ParseFunction(SourceFileData data, ref int rowidx)
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
            return new FunctionData(data.Source.FileName, name, rt, body.ToArray());
        }

        public FunctionData[] ParseFunctions(FilePath src)
        {
            var dst = list<FunctionData>();
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
            => text.empty(src.Text);

        bool Contains(TextRow src, string substring)
            => src.Text.ContainsAny(substring);

        bool Skip(TextRow src)
            => IsComment(src) || IsEmpty(src);
    }
}
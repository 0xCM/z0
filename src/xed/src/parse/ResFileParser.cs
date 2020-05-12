//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Memories;

    using static InstructionFileMarkers;
    public class InstructionFileMarkers
    {
        /// <summary>
        /// Whe encountered, signals a list  of  insruction specifications to follow,
        /// where each specification covers multiple lines of text, bounded above by
        /// a line containing a single left-brace and below by a line cotaining a
        /// single right-brace
        /// </summary>
        public const string SeqBegin = "INSTRUCTIONS()::";

        /// <summary>
        /// When encountered, signals a sequence of lines that describe an instruciton
        /// </summary>
        public const string LeftDelimiter = "{" ;

        /// <summary>
        /// When encountered, signals that a sequence of instruction description lines has concluded
        /// </summary>
        public const string RightDelimiter = "}" ;
    }

    public readonly struct ResFileParser
    {
        public static ResFileParser Service => default(ResFileParser);

        public ResFileData ReadResFile(FilePath src)
        {
            return src.ReadTextDoc(TextFormat.Unstructured()).MapValueOrDefault(c => ResFileData.Define(c.RowData), ResFileData.Empty);
        }

        bool IsLeftDelimiter(TextRow src)
            => src.Text.Contains(LeftDelimiter);

        bool IsRightDelimiter(TextRow src)
            => src.Text.Contains(RightDelimiter);
    
        bool Skip(TextRow src)
            => src.Text.StartsWith("#") || text.empty(src.Text);

        public ResInstruction ParseInstruction(ResFileData src, in int idxStart, ref int idxterm)
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
            return new ResInstruction(rows.ToArray());
        }


        ResInstruction[] ParseSequence(ResFileData data, int idx)
        {
            var dst = list<ResInstruction>();            
            for(var i=0; i<data.RowCount; i++)
            {
                var parsed = ParseInstruction(data, ++i, ref i);
                if(parsed.IsNonEmpty)
                    dst.Add(parsed);
            }
            return dst.ToArray();
        }

        public ResInstruction[] ParseInstructions(FilePath src)
        {
            var data = ReadResFile(src);
            for(var i=0; i<data.RowCount; i++)
            {
                if(data[i].Text.ContainsAny(SeqBegin))  
                    return ParseSequence(data, i);
            }
            return Control.array<ResInstruction>();
        }
    }
}
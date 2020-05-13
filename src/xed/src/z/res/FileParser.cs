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
        public const string InstructionSeq = "INSTRUCTIONS()::";

        /// <summary>
        /// When encountered, signals a sequence of lines that describe an instruciton
        /// </summary>
        public const string LeftDelimiter = "{" ;

        /// <summary>
        /// When encountered, signals that a sequence of instruction description lines has concluded
        /// </summary>
        public const string RightDelimiter = "}" ;
    }

    partial class Res
    {
        public readonly struct FileParser
        {
            public static FileParser Service => default(FileParser);

            public FileData ReadResFile(FilePath src)
            {
                return src.ReadTextDoc(TextFormat.Unstructured()).MapValueOrDefault(c => FileData.Define(c.RowData), FileData.Empty);
            }

            bool IsLeftDelimiter(TextRow src)
                => src.Text.Contains(LeftDelimiter);

            bool IsRightDelimiter(TextRow src)
                => src.Text.Contains(RightDelimiter);
        
            bool Skip(TextRow src)
                => src.Text.StartsWith("#") || text.empty(src.Text);

            public Instruction ParseInstruction(FileData src, in int idxStart, ref int idxterm)
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
                return new Instruction(rows.ToArray());
            }


            Instruction[] ParseSequence(FileData data, int idx)
            {
                var dst = list<Instruction>();            
                for(var i=0; i<data.RowCount; i++)
                {
                    var parsed = ParseInstruction(data, ++i, ref i);
                    if(parsed.IsNonEmpty)
                        dst.Add(parsed);
                }
                return dst.ToArray();
            }

            public Instruction[] ParseInstructions(FilePath src)
            {
                var data = ReadResFile(src);
                for(var i=0; i<data.RowCount; i++)
                {
                    if(data[i].Text.ContainsAny(InstructionSeq))  
                        return ParseSequence(data, i);
                }
                return Control.array<Instruction>();
            }
        }
    }
}
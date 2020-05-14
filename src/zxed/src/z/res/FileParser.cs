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

    using static InstructionMarkers;

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
                => src.Text.Contains(DECL_BEGIN);

            bool IsRightDelimiter(TextRow src)
                => src.Text.Contains(DECL_END);
        
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
                    if(data[i].Text.ContainsAny(INSTRUCTION_SEQ))  
                        return ParseSequence(data, i);
                }
                return Control.array<Instruction>();
            }
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;

    public class t_tokens : t_asmd<t_tokens>
    {
        public void opcode_tokens()
        {
            var data = OpCodeDataset.Create();
            var count = data.OpCodeCount;
            var records = data.OpCodeRecords.ToReadOnlySpan();
            var identifers = data.OpCodeIdentifiers.ToReadOnlySpan();
            Claim.eq(count, records.Length);
            Claim.eq(count, identifers.Length);

            var processor = OpCodeProcessor.Create();
            var handler = OpCodeHandler.Create(count);
            processor.Process(records,handler);

            var groups = handler.CommandGroups;

            Trace($"Processed {handler.ProcessedCount} records");
            Trace($"Distilled {groups.Length} mnemonics");

            
        }
        
        void instruction_tokens()
        {
            const byte Delimiter = InstructionTokenDataset.EncodingDelimiter;
            const int BufferLength = 32;

            var data = InstructionTokenDataset.Create();
            ReadOnlySpan<byte> src = data.ValueEncoding;
            var count = src.Length;
            var dst = list<TokenValue>(data.TokenCount);
            
            Span<byte> buffer = stackalloc byte[BufferLength];
            buffer.Clear();
            
            for(int i=0, j=0; i<count && j < BufferLength; i++, j++)
            {                
                ref readonly var cell = ref skip(src,i);                
                if(cell == Delimiter)
                {
                    var cells = buffer.Slice(0,j).ToArray();
                    dst.Add(TokenValue.Define(cells));
                    
                    buffer.Clear();
                    j=0;
                }
                else
                {
                    buffer[j] = cell;
                }
            }
            Trace($"Processed {dst.Count} tokens");
        }

        public void opcode_resource_doc()
        {
            const char TextDelimiter = Chars.Pipe;
            var svc = AsmD.Service;
            var count1 = svc.OpCodeSpecDoc.CharCount(TextDelimiter);
            var count2 = Symbolic.count(svc.OpCodeSpecText, 1, TextDelimiter);
            Claim.eq(count1,count2);
        }
    }
}
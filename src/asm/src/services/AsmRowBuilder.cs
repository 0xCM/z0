//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Part;
    using static memory;

    public sealed class AsmRowBuilder : AppService<AsmRowBuilder>
    {
        readonly Dictionary<AsmMnemonic, ArrayBuilder<AsmDetailRow>> Index;

        int Sequence;

        uint Offset;

        AsmDecoder Decoder;

        public AsmRowBuilder()
        {
            Sequence = 0;
            Offset = 0;
            Index = new Dictionary<AsmMnemonic, ArrayBuilder<AsmDetailRow>>();
        }

        protected override void OnInit()
        {
            Decoder = Wf.AsmDecoder();
        }

        [MethodImpl(Inline), Op]
        public Index<AsmDetailRow> Resequence(Index<AsmDetailRow> src)
        {
            var count = src.Length;
            ref var row = ref src.First;
            for(var i=0u; i<count;i++)
                seek(row,i).Sequence = i;
            return src;
        }

        public Index<AsmDetailRow> EmitAsmRows(Index<ApiCodeBlock> src)
        {
            var rows = BuildAsmRows(src);
            var rowsets = @readonly(rows.GroupBy(x => x.Mnemonic).Select(x => AsmEtl.rowset(x.Key, x.Array())).Array());
            var count = rowsets.Length;
            var etl = Wf.AsmEtl();
            for(var i=0; i<count; i++)
                etl.Emit(skip(rowsets,i));
            return rows;
        }

        public Index<AsmDetailRow> BuildAsmRows(Index<ApiCodeBlock> src)
        {
            var view = src.View;
            var count = view.Length;
            var flow = Wf.Running(Msg.CreatingAsmRowsFromBlocks.Format(count));
            var rows = root.list<AsmDetailRow>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var block = ref skip(view,i);
                rows.AddRange(BuildAsmRows(block));
            }

            Wf.Ran(flow,Msg.CreatedAsmRowsFromBlocks.Format(rows.Count));
            return rows.ToArray();
        }

        Index<AsmDetailRow> BuildAsmRows(in ApiCodeBlock src)
        {
            var outcome = Decoder.Decode(src, out var block);
            if(outcome)
                return BuildAsmRows(src.Code, block);
            else
            {
                Wf.Error(outcome.Message);
                return sys.empty<AsmDetailRow>();
            }
        }

        Index<AsmDetailRow> BuildAsmRows(in CodeBlock code, IceInstruction[] src)
        {
            var bytes = span(code.Storage);
            var offset = z16;
            var count = src.Length;
            var buffer = alloc<AsmDetailRow>(count);
            var dst = span(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref src[i];
                var size = (ushort)instruction.ByteLength;
                FillAsmRow(code, new Address16(offset), bytes.Slice(offset, size), instruction, ref seek(dst,i));
                offset += size;
            }
            return buffer;
        }

        void FillAsmRow(in CodeBlock code, Address16 offset, Span<byte> encoded, in IceInstruction src, ref AsmDetailRow record)
        {
            record.Sequence = (uint)NextSequence;
            record.BlockAddress = code.BaseAddress;
            record.IP = src.IP;
            record.LocalOffset = offset;
            record.GlobalOffset = NextOffset;
            record.Mnemonic = src.AsmMnemonic;
            record.OpCode = src.Specifier.OpCode;
            record.Encoded = new BinaryCode(encoded.TrimEnd().ToArray());
            record.Statement = src.FormattedInstruction;
            record.Instruction = src.Specifier.Sig.Format();
            record.CpuId = text.embrace(src.CpuidFeatures.Select(x => x.ToString()).Join(","));
            record.OpCodeId = src.Code.ToString();
            if(Index.TryGetValue(src.AsmMnemonic, out var builder))
                builder.Include(record);
            else
                Index.Add(src.AsmMnemonic, ArrayBuilder.build(record));
        }

        int NextSequence
        {
            [MethodImpl(Inline)]
            get => Sequence++;
        }

        Address32 NextOffset
        {
            [MethodImpl(Inline)]
            get => Offset++;
        }
    }
}
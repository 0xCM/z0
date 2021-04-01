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

    public sealed class AsmRowStore : AsmWfService<AsmRowStore>
    {
        readonly Dictionary<AsmMnemonic, ArrayBuilder<AsmRow>> Index;

        int Sequence;

        uint Offset;

        public AsmRowStore()
        {
            Sequence = 0;
            Offset = 0;
            Index = new Dictionary<AsmMnemonic, ArrayBuilder<AsmRow>>();
        }

        public Index<AsmRow> CreateAsmRows(Index<ApiCodeBlock> src)
        {
            var count = src.Count;
            var flow = Wf.Running(Msg.CreatingAsmRowsFromBlocks.Format(src.Count));
            ref readonly var block = ref src.First;
            var buffer = root.list<AsmRow>();
            for(var i=0u; i<count; i++)
                buffer.AddRange(CreateAsmRows(skip(block,i)));
            Wf.Ran(flow,Msg.CreatedAsmRowsFromBlocks.Format(buffer.Count));
            return buffer.ToArray();
        }

        public Index<AsmRow> CreateAsmRows(ApiCodeBlocks src)
        {
            var flow = Wf.Running(Msg.CreatingAsmRowsFromBlocks.Format(src.BlockCount));
            var addresses = src.Addresses.View;
            var count = addresses.Length;
            var rows = root.list<AsmRow>();
            for(var i=0u; i<count; i++)
                rows.AddRange(CreateAsmRows(src[skip(addresses, i)]));
            Wf.Ran(flow,Msg.CreatedAsmRowsFromBlocks.Format(rows.Count));
            return rows.ToArray();
        }

        public AsmRowSets<AsmMnemonic> EmitRowsets(ApiCodeBlocks src)
        {
            using var flow = Wf.Running();
            var rows = CreateAsmRows(src);
            var rowsets = CreateRowsets();
            Wf.Ran(flow);
            return rowsets;
        }

        public AsmRowSets<AsmMnemonic> EmitAsmRows(ApiCodeBlocks src)
        {
            try
            {
                var etl = Wf.AsmRowEtl();
                var rowsets = EmitRowsets(src);
                var records = 0u;
                var sets = rowsets.View;
                var count = rowsets.Count;
                var flow = Wf.Running(Msg.EmittingInstructionRecords.Format(count));
                for(var i=0; i<count; i++)
                    records += etl.Emit(skip(sets,i));

                Wf.Ran(flow, Msg.EmittedInstructionRecords.Format(records, count));

                return rowsets;

            }
            catch(Exception e)
            {
                Wf.Error(e);
                return AsmRowSets<AsmMnemonic>.Empty;
            }
        }

        AsmRowSets<AsmMnemonic> CreateRowsets()
        {
            var keys = Index.Keys.ToArray();
            var count = keys.Length;
            var sets = new AsmRowSet<AsmMnemonic>[count];
            for(var i=0; i<count; i++)
            {
                var key = keys[i];
                sets[i] = AsmEtl.rowset(key, Index[key].Emit());
            }
            return AsmEtl.rowsets(sets);
        }

        Index<AsmRow> CreateAsmRows(in ApiCodeBlock src)
        {
            var decoded = Asm.RoutineDecoder.Decode(src);
            if(decoded)
                return CreateAsmRows(src.Code, decoded.Value);
            else
            {
                Wf.Error($"Error decoding {src.OpUri}");
                return sys.empty<AsmRow>();
            }
        }

        Index<AsmRow> CreateAsmRows(in CodeBlock code, IceInstruction[] src)
        {
            var bytes = span(code.Storage);
            var offset = z16;
            var count = src.Length;
            var buffer = alloc<AsmRow>(count);
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

        void FillAsmRow(in CodeBlock code, Address16 offset, Span<byte> encoded, in IceInstruction src, ref AsmRow record)
        {
            record.Sequence = (uint)NextSequence;
            record.BlockAddress = code.BaseAddress;
            record.IP = src.IP;
            record.LocalOffset = offset;
            record.GlobalOffset = NextOffset;
            record.Mnemonic = src.AsmMnemonic;
            record.OpCode = asm.opcode(AsmOpCodes.conform(src.Specifier.OpCode.ToString()));
            record.Encoded = new BinaryCode(encoded.TrimEnd().ToArray());
            record.Statement = src.FormattedInstruction;
            record.Instruction = src.Specifier.Sig;
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
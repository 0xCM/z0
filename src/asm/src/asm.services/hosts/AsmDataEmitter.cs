//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Part;
    using static z;

    public readonly struct AsmDataEmitter
    {
        readonly Dictionary<IceMnemonic, ArrayBuilder<AsmRow>> Index;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly ApiCodeBlocks Encoded;

        readonly int[] Sequence;

        readonly uint[] Offset;

        IAsmDecoder Decoder
            => Asm.RoutineDecoder;

        int NextSequence
        {
            [MethodImpl(Inline)]
            get => Sequence[0]++;
        }

        Address32 NextOffset
        {
            [MethodImpl(Inline)]
            get => Offset[0]++;
        }

        [MethodImpl(Inline)]
        public AsmDataEmitter(IWfShell wf, IAsmContext asm, in ApiCodeBlocks encoded)
        {
            Wf = wf;
            Asm = asm;
            Encoded = encoded;
            Index = new Dictionary<IceMnemonic, ArrayBuilder<AsmRow>>();
            Sequence = sys.alloc<int>(1);
            Offset = sys.alloc<uint>(1);
        }

        public AsmRowSets<IceMnemonic> Emit()
        {
            using var flow = Wf.Running();
            var addresses = Encoded.Addresses.View;
            var count = addresses.Length;
            for(var i=0u; i<count; i++)
                CreateRecords(Encoded[skip(addresses, i)]);
            return Rowsets();
        }

        void CreateRecords(in ApiCodeBlock src)
        {
            var decoded = Decoder.Decode(src.Code);
            if(decoded)
                CreateRecords(src.Code, decoded.Value);
        }

        void CreateRecords(in CodeBlock code, in IceInstructionList asm)
        {
            var data = code.Code;
            var bytes = data.View;
            var instructions = asm.Data;
            CreateRecords(code, instructions);
        }

        void CreateRecords(in CodeBlock code, IceInstruction[] src)
        {
            var bytes = span(code.Storage);
            ushort offset = 0;

            for(var i=0; i<src.Length; i++)
            {
                ref readonly var instruction = ref src[i];

                var size = (ushort)instruction.ByteLength;
                var encoded = bytes.Slice(offset, size);

                var a16 = new Address16(offset);
                CreateRecord(code, a16, encoded, instruction);
                offset += size;
            }
        }

        void CreateRecord(in CodeBlock code, Address16 offset, Span<byte> encoded, in IceInstruction src)
        {
            var mnemonic = src.Mnemonic;

            if(mnemonic != 0)
            {
                var record = new AsmRow();
                record.Sequence = NextSequence;
                record.BlockAddress = code.BaseAddress;
                record.IP = src.IP;
                record.LocalOffset = offset;
                record.GlobalOffset = NextOffset;
                record.Mnemonic = mnemonic.ToString().ToUpper();
                record.OpCode = src.Specifier.OpCode;
                record.Encoded = new BinaryCode(encoded.TrimEnd().ToArray());
                record.SourceCode = src.FormattedInstruction;
                record.Instruction = src.Specifier.Sig;
                record.CpuId = text.embrace(src.CpuidFeatures.Select(x => x.ToString()).Concat(","));
                record.OpCodeId = (IceOpCodeId)src.Code;

                if(Index.TryGetValue(mnemonic, out var builder))
                    builder.Include(record);
                else
                    Index.Add(mnemonic, ArrayBuilder.build(record));
            }
        }

        AsmRowSets<IceMnemonic> Rowsets()
        {
            var keys = Index.Keys.ToArray();
            var count = keys.Length;
            var sets = new AsmRowSet<IceMnemonic>[count];
            for(var i=0; i<count; i++)
            {
                var key = keys[i];
                sets[i] = asm.rowset(key, Index[key].Emit());
            }
            return asm.rowsets(sets);
        }
    }
}
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

    using static Konst;
    using static z;
    using static ProcessAsmStep;

    [Step]
    public readonly struct ProcessAsmStep : IWfStep<ProcessAsmStep>
    {
        public static WfStepId StepId
            => Workflow.step<ProcessAsmStep>();
    }


    public readonly struct ProcessAsm
    {
        readonly Dictionary<Mnemonic, ArrayBuilder<AsmRow>> Index;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly ApiCodeBlockIndex Encoded;

        readonly int[] Sequence;

        readonly uint[] Offset;

        readonly AsmMnemonicParser Parser;

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
        public ProcessAsm(IWfCaptureState state, in ApiCodeBlockIndex encoded)
        {
            Wf = state.Wf;
            Asm = state.Asm;
            Encoded = encoded;
            Parser = AsmMnemonicParser.Create();
            Index = new Dictionary<Mnemonic, ArrayBuilder<AsmRow>>();
            Sequence = sys.alloc<int>(1);
            Offset = sys.alloc<uint>(1);
        }

        public AsmRowSets<Mnemonic> Process()
        {
            Wf.Running(StepId);
            var locations = span(Encoded.Locations);
            var count = locations.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var address = ref skip(locations,i);
                Process(Encoded[address]);
            }

            var result = Processed();
            Wf.Ran(StepId, result.Count);

            return result;
        }

        [MethodImpl(Inline)]
        void Process(in ApiCodeBlock src)
        {
            var decoded = Decoder.Decode(src.Code);
            if(decoded)
                Process(src.Code, decoded.Value);
        }

        void Process(in ApiParseBlock src)
        {
            var instructions = Decoder.Decode(src.Data);
            if(instructions)
                Process(src.Data, instructions.Value);
        }

        AsmRowSets<Mnemonic> Processed()
        {
            var keys = Index.Keys.ToArray();
            var count = keys.Length;
            var sets = new AsmRowSet<Mnemonic>[count];
            for(var i=0; i<count; i++)
            {
                var key = keys[i];
                sets[i] = asm.set(key, Index[key].Create());
            }
            return asm.sets(sets);
        }

        void Process(in BasedCodeBlock code, in AsmFxList asm)
        {
            var data = code.Data;
            var bytes = data.ToReadOnlySpan();
            var instructions = asm.Data;
            Process(code.Encoded, instructions);
        }

        void Process(in BinaryCode code, Instruction[] asm)
        {
            var bytes = span(code.Data);
            ushort offset = 0;

            for(var i=0; i<asm.Length; i++)
            {
                ref readonly var instruction = ref asm[i];

                var size = (ushort)instruction.ByteLength;
                var encoded = bytes.Slice(offset, size);

                var a16 = new Address16(offset);
                Process(a16, encoded, instruction);
                offset += size;
            }
        }

        [MethodImpl(Inline)]
        void Process(Address16 localOffset, Span<byte> encoded, in Instruction asm)
        {
            var mnemonic = asm.Mnemonic;

            if(mnemonic != 0)
            {
                var record = new AsmRow(
                    Sequence: NextSequence,
                    Address: asm.IP,
                    LocalOffset: localOffset,
                    GlobalOffset: NextOffset,
                    Mnemonic: mnemonic.ToString().ToUpper(),
                    OpCode: asm.InstructionCode.OpCode,
                    Encoded: new BinaryCode(encoded.TrimEnd().ToArray()),
                    SourceCode: asm.FormattedInstruction,
                    Instruction: asm.InstructionCode.Instruction,
                    CpuId: text.embrace(asm.CpuidFeatures.Select(x => x.ToString()).Concat(",")),
                    Id: (OpCodeId)asm.Code
                    );

                if(Index.TryGetValue(mnemonic, out var builder))
                    builder.Include(record);
                else
                    Index.Add(mnemonic, ArrayBuilder.Create(record));
            }
        }
    }
}
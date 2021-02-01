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

    public class AsmDataEmitter
    {
        readonly Dictionary<IceMnemonic, ArrayBuilder<AsmRow>> Index;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        public ApiCodeBlocks CodeBlocks {get; private set;}

        public Index<ApiPartRoutines> Decoded {get; private set;}

        readonly int[] Sequence;

        readonly uint[] Offset;

        public AsmDataEmitter()
        {
            Sequence = sys.alloc<int>(1);
            Offset = sys.alloc<uint>(1);
            Index = new Dictionary<IceMnemonic, ArrayBuilder<AsmRow>>();
        }

        [MethodImpl(Inline)]
        public AsmDataEmitter(IWfShell wf, IAsmContext asm)
            : this()
        {
            Wf = wf;
            Asm = asm;
            Init();
        }

        void Init()
        {
            CodeBlocks = ApiIndex.service(Wf).CreateApiBlocks();
            Decoded = ApiDecoder.init(Wf,Asm).DecodeIndex(CodeBlocks);
        }

        public AsmRowSets<IceMnemonic> Emit()
        {
            using var flow = Wf.Running();
            var addresses = CodeBlocks.Addresses.View;
            var count = addresses.Length;
            for(var i=0u; i<count; i++)
                CreateRecords(CodeBlocks[skip(addresses, i)]);

            Wf.Ran(flow);

            return Rowsets();
        }

        public void EmitAsmRows()
        {
            try
            {
                var rowsets = Emit();
                var records = 0u;
                var sets = rowsets.View;
                var count = rowsets.Count;

                var flow = Wf.Running(Msg.EmittingInstructionRecords.Format(count));
                for(var i=0; i<count; i++)
                    records += AsmEtl.emit(Wf, skip(sets,i));

                Wf.Ran(flow, Msg.EmittedInstructionRecords.Format(records, count));

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        public void EmitJmpRows()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                EmitJumpRows(Decoded[i]);
        }

        public void EmitJumpRows(ApiPartRoutines src)
        {
            var collector = AsmJmpCollector.create(Wf);
            var rows = collector.Collect(src);
            var emitter = AsmJmpEmitter.create(Wf);
            var dst = Wf.Db().Table(AsmJmpRow.TableId, src.Part);
            emitter.Emit(rows, dst);
        }

        public void EmitCallRows()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                EmitCallRows(Decoded[i]);
        }

        public void EmitCallRows(ApiPartRoutines src)
        {
            var dst = Wf.Db().Table(AsmCallRow.TableId, src.Part);
            Wf.EmittingTable<AsmCallRow>(dst);
            using var writer = dst.Writer();
            var calls = AsmEtl.calls(src.Instructions()).View;
            var count = calls.Length;
            var formatter = Records.formatter<AsmCallRow>();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(calls,i)));
            Wf.EmittedTable<AsmCallRow>(count, dst);
        }

        void CreateRecords(in ApiCodeBlock src)
        {
            var decoded = Asm.RoutineDecoder.Decode(src.Code);
            if(decoded)
                CreateRecords(src.Code, decoded.Value);
        }

        void CreateRecords(in CodeBlock code, in IceInstructionList asm)
            => CreateRecords(code, asm.Storage);

        void CreateRecords(in CodeBlock code, IceInstruction[] src)
        {
            var bytes = span(code.Storage);
            var offset = z16;
            var count = src.Length;

            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref src[i];
                var size = (ushort)instruction.ByteLength;
                CreateRecord(code, new Address16(offset), bytes.Slice(offset, size), instruction);
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
                record.Statement = src.FormattedInstruction;
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
                sets[i] = AsmEtl.rowset(key, Index[key].Emit());
            }
            return AsmEtl.rowsets(sets);
        }

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
    }

    partial struct Msg
    {
        public static RenderPattern<Count> EmittingInstructionRecords => "Emitting {0} instruction tables";

        public static RenderPattern<Count,Count> EmittedInstructionRecords => "Emitted a total of {0} records for {1} instruction tables";

    }
}
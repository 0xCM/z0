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
        public AsmDataEmitter(IWfShell wf, IAsmContext asm, in ApiCodeBlocks blocks, Index<ApiPartRoutines> decoded)
            : this()
        {
            Wf = wf;
            Asm = asm;
            CodeBlocks = blocks;
            Decoded = decoded;
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
            return Rowsets();
        }

        public void EmitAsmRows()
        {
            try
            {
                var result = Emit();
                var records = 0u;

                Wf.Processed(Seq.delimit(nameof(AsmRow), CodeBlocks.Hosts.Count, result.Count));

                var sets = result.View;
                var count = result.Count;
                Wf.Status($"Emitting {count} instruction tables");
                for(var i=0; i<count; i++)
                    records += AsmEtl.emit(Wf, skip(sets,i));
                Wf.Status($"Emitted a total of {records} records for {count} instruction tables");

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
            var step = new AsmJmpRowEmitter(Wf, src);
            step.Emit();
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
            var records = @readonly(AsmEtl.calls(src.Instructions));
            var count = records.Length;
            writer.WriteLine(AsmCallRow.header());
            for(var i=0; i<count; i++)
                writer.WriteLine(format(skip(records,i)));
            Wf.EmittedTable<AsmCallRow>(count, dst);
        }

        void CreateRecords(in ApiCodeBlock src)
        {
            var decoded = Asm.RoutineDecoder.Decode(src.Code);
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

        static string format(in AsmCallRow src)
            => string.Format(AsmCallRow.RenderPattern, src.Source, src.Target, src.InstructionSize, src.TargetOffset, src.Instruction, src.Encoded);
    }
}
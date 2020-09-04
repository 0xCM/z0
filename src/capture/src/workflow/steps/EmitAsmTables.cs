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

    using static EmitAsmTablesStep;

    public ref struct EmitAsmTables
    {
        readonly IWfCaptureState State;

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        readonly GlobalCodeIndex Encoded;

        readonly CorrelationToken Ct;

        readonly ReadOnlySpan<MemoryAddress> Locations;

        AsmTableSeg<Mnemonic>[] Segments;

        int Sequence;

        uint Offset;

        readonly Dictionary<Mnemonic, ArrayBuilder<AsmRecord>> Index;

        ReadOnlySpan<Mnemonic> Keys
            => Index.Keys.ToArray();

        IAsmDecoder Decoder
            => Asm.RoutineDecoder;

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

        public EmitAsmTables(IWfCaptureState state, GlobalCodeIndex encoded)
        {
            State = state;
            Wf = state.Wf;
            Ct = Wf.Ct;
            Encoded = encoded;
            Locations = encoded.Locations;
            Sequence = 0;
            Offset = 0;
            Index = new Dictionary<Mnemonic, ArrayBuilder<AsmRecord>>();
            Asm = state.Asm;
            Segments = sys.empty<AsmTableSeg<Mnemonic>>();
            Wf.Created(StepId, Ct);
        }

        public void Dispose()
        {
            Wf.Disposed(StepId);
        }

        public void Run()
        {
            Wf.Running(StepId);

            var count = Locations.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var address = ref skip(Locations,i);
                Process(Encoded[address]);
            }

            Collect();

            var offset = 0;
            for(var i=0; i<Segments.Length; i++)
            {
                var seg = Segments[i];
                Save(seg,offset);
                offset += seg.Count;
            }

            Wf.Ran(StepId);
        }

        void Save(in AsmTableSeg<Mnemonic> src, int offset)
        {
            var count = src.Count;
            var buffer = span(src.Content.Array);
            var tables = buffer.Slice(offset,count);
            var dir = (Wf.ResourceRoot + FolderName.Define("tables")) + FolderName.Define("asm");
            var dst = dir + FileName.define(src.Key.ToString(), FileExtensions.Csv);
            using var writer = dst.Writer();
            writer.WriteLine(AsmRecord.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(tables,i);
                writer.WriteLine(record.Format());
            }
        }

        [MethodImpl(Inline)]
        void Process(in X86ApiCode src)
        {
            var decoded = Decoder.Decode(src.Encoded);
            if(decoded)
                Process(src.Encoded, decoded.Value);
        }

        Count32 RecordCount()
        {
            var count = 0u;
            var keys = Keys;
            for(var i=0; i<keys.Length; i++)
                count += Index[skip(keys,i)].Count;
            return count;
        }

        void Collect()
        {
            var kTables = RecordCount();
            var buffer = sys.alloc<AsmRecord>(kTables);
            var tables = span(buffer);
            var keys = Keys;
            var kKeys = keys.Length;
            Segments = new AsmTableSeg<Mnemonic>[kTables];
            var dst = span(Segments);

            var offset = 0;
            for(uint i=0u; i<kKeys; i++)
            {
                var key = skip(keys,i);
                var current = Index[key];

                current.CopyTo(tables, (uint)offset);

                var s0 = offset;
                offset += (int)current.Count.Value;
                var s1 = offset;

                seek(dst,i) = AsmRecords.segment(key, new ArraySegment<AsmRecord>(buffer, s0, s1-s0));
            }
        }

        void Process(in X86Code code, in AsmFxList asm)
        {
            Process(code.Encoded, asm.Data);
        }

        void Process(in BinaryCode code, Instruction[] asm)
        {
            var bytes = Root.span(code.Data);

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

        void Process(Address16 localOffset, Span<byte> encoded, in Instruction asm)
        {
            var mnemonic = asm.Mnemonic;

            if(mnemonic != 0)
            {
                var record = new AsmRecord(
                    Sequence: NextSequence,
                    Address: asm.IP,
                    LocalOffset: localOffset,
                    GlobalOffset: NextOffset,
                    Mnemonic: mnemonic.ToString().ToUpper(),
                    OpCode: asm.InstructionCode.OpCode.Replace("o32 ", string.Empty),
                    Encoded: new BinaryCode(encoded.TrimEnd().ToArray()),
                    InstructionFormat: asm.FormattedInstruction,
                    InstructionCode: asm.InstructionCode.Expression,
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
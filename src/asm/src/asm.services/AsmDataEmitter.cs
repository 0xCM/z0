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

    public sealed class AsmDataEmitter : AsmWfService<AsmDataEmitter>
    {
        readonly Dictionary<IceMnemonic, ArrayBuilder<AsmRow>> Index;

        AsmRecords Recordset;

        ApiCodeBlocks CodeBlocks;

        int Sequence;

        uint Offset;

        public ApiAsmDataset Dataset {get; private set;}

        public AsmDataEmitter()
        {
            Sequence = 0;
            Offset = 0;
            Index = new Dictionary<IceMnemonic, ArrayBuilder<AsmRow>>();
            Dataset = ApiAsmDataset.Empty;
            Recordset = AsmRecords.Empty;
            CodeBlocks = ApiCodeBlocks.Empty;
        }

        protected override void OnInit()
        {
            base.OnInit();
            CodeBlocks = Wf.ApiHexIndexer().IndexApiBlocks();
            Dataset = Wf.ApiIndexDecoder().Decode(CodeBlocks);
        }

        public ApiAsmDataset Run()
        {
            EmitAsmRows();
            EmitCallRows();
            EmitJmpRows();
            EmitSemantic();
            EmitResBytes();
            return Dataset;
        }

        public AsmRowSets<IceMnemonic> EmitAsmRows()
        {
            try
            {
                var rowsets = EmitRowsets();
                var records = 0u;
                var sets = rowsets.View;
                var count = rowsets.Count;
                var flow = Wf.Running(Msg.EmittingInstructionRecords.Format(count));
                for(var i=0; i<count; i++)
                    records += AsmEtl.emit(Wf, skip(sets,i));

                Wf.Ran(flow, Msg.EmittedInstructionRecords.Format(records, count));

                Recordset.With(rowsets);
                return rowsets;

            }
            catch(Exception e)
            {
                Wf.Error(e);
                return AsmRowSets<IceMnemonic>.Empty;
            }
        }

        public Index<AsmJmpRow> EmitJmpRows()
        {
            var dst = root.list<AsmJmpRow>();
            var routines = Dataset.Routines;
            var count = routines.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(EmitJumpRows(routines[i]));
            var rows = dst.ToArray();
            Recordset.With(rows);
            return rows;
        }

        public void EmitSemantic()
        {
            var routines = Dataset.Routines;
            var render = Wf.AsmSemanticRender();
            var count = routines.Length;
            for(var i=0; i<count; i++)
                render.Render(routines[i]);
        }


        public Index<ApiHostRes> EmitResBytes()
            => Wf.ResBytesEmitter().Emit(CodeBlocks);

        public Index<AsmJmpRow> EmitJumpRows(ApiPartRoutines src)
        {
            var collector = Wf.AsmJmpCollector();
            var rows = collector.Collect(src);
            Emit(rows, Db.Table(AsmJmpRow.TableId, src.Part));
            return rows;
        }

        void Emit(ReadOnlySpan<AsmJmpRow> src, FS.FilePath dst)
        {
            if(src.Length != 0)
            {
                var flow = Wf.EmittingTable<AsmJmpRow>(dst);
                var formatter = Records.formatter<AsmJmpRow>();
                using var writer = dst.Writer();
                writer.WriteLine(formatter.FormatHeader());
                var count = src.Length;
                for(var i=0u; i<count; i++)
                    writer.WriteLine(formatter.Format(skip(src,i)));
                Wf.EmittedTable<AsmJmpRow>(flow, count, dst);
            }
        }

        public Index<AsmCallRow> EmitCallRows()
        {
            var dst = root.list<AsmCallRow>();
            var routines = Dataset.Routines;
            var count = routines.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(EmitCallRows(routines[i]));
            var rows = dst.ToArray();
            Recordset.With(rows);
            return rows;
        }

        public Index<AsmCallRow> EmitCallRows(ApiPartRoutines src)
        {
            var dst = Db.Table(AsmCallRow.TableId, src.Part);
            var flow = Wf.EmittingTable<AsmCallRow>(dst);
            using var writer = dst.Writer();
            var calls = AsmEtl.calls(src.Instructions());
            var view = calls.View;
            var count = view.Length;
            var formatter = Records.formatter<AsmCallRow>();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(view,i)));
            Wf.EmittedTable(flow, count);
            return calls;
        }

        void CreateRecords(in ApiCodeBlock src)
        {
            var decoded = Asm.RoutineDecoder.Decode(src.Code);
            if(decoded)
                CreateRecords(src.Code, decoded.Value);
        }

        void CreateRecords(in CodeBlock code, in IceInstructionList asm)
            => CreateRecords(code, asm.Storage);

        FS.FolderPath RespackDir
            => Db.PartDir("respack") + FS.folder("content") + FS.folder("bytes");


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
                record.Sequence = (uint)NextSequence;
                record.BlockAddress = code.BaseAddress;
                record.IP = src.IP;
                record.LocalOffset = offset;
                record.GlobalOffset = NextOffset;
                record.Mnemonic = mnemonic.ToString().ToUpper();
                record.OpCode = src.Specifier.OpCode;
                record.Encoded = new BinaryCode(encoded.TrimEnd().ToArray());
                record.Statement = src.FormattedInstruction;
                record.Instruction = src.Specifier.Sig;
                record.CpuId = text.embrace(src.CpuidFeatures.Select(x => x.ToString()).Join(","));
                record.OpCodeId = (IceOpCodeId)src.Code;

                if(Index.TryGetValue(mnemonic, out var builder))
                    builder.Include(record);
                else
                    Index.Add(mnemonic, ArrayBuilder.build(record));
            }
        }

        AsmRowSets<IceMnemonic> EmitRowsets()
        {
            using var flow = Wf.Running();
            var blocks = Dataset.Blocks;
            var addresses = blocks.Addresses.View;
            var count = addresses.Length;
            for(var i=0u; i<count; i++)
                CreateRecords(blocks[skip(addresses, i)]);
            Wf.Ran(flow);

            return LoadRowSets();
        }

        AsmRowSets<IceMnemonic> LoadRowSets()
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
            get => Sequence++;
        }

        Address32 NextOffset
        {
            [MethodImpl(Inline)]
            get => Offset++;
        }
    }
}
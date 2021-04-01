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

        [MethodImpl(Inline), Op]
        public Index<AsmRow> Resequence(Index<AsmRow> src)
        {
            var count = src.Length;
            ref var row = ref src.First;
            for(var i=0u; i<count;i++)
                seek(row,i).Sequence = i;
            return src;
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

        public uint Emit(AsmRowSet<AsmMnemonic> src)
        {
            var count = src.Count;
            if(count != 0)
            {
                var dst = Db.Table(AsmRow.TableId, src.Key.ToString());
                var flow = Wf.EmittingTable<AsmRow>(dst);
                var records = span(src.Sequenced);
                var formatter = Tables.formatter<AsmRow>(32);
                using var writer = dst.Writer();
                writer.WriteLine(formatter.FormatHeader());
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(records,i);
                    writer.WriteLine(formatter.Format(record));
                }
                Wf.EmittedTable(flow, count);
            }
            return count;
        }

        [Op]
        public Index<AsmCallRow> CallRows(Index<ApiInstruction> src)
        {
            var calls = ApiInstruction.filter(src, AsmMnemonicCode.CALL).View;
            var count = calls.Length;
            var buffer = alloc<AsmCallRow>(count);
            ref var row = ref first(span(buffer));
            for(var i=0u; i<count; i++)
            {
                ref readonly var call = ref skip(calls,i);
                ref var dst = ref seek(row,i);
                var bytes = span(call.EncodedData.Storage);
                var offset = ByteReader.read(bytes.Slice(1));
                var target = call.NextIp + offset;
                dst.Source = call.IP;
                dst.Target = target;
                dst.InstructionSize = call.ByteLength;
                dst.TargetOffset = target - (call.IP + src.Length);
                dst.Instruction = call.FormattedInstruction;
                dst.Encoded = call.Encoded.Storage;
            }
            return buffer;
        }

        public Index<AsmCallRow> EmitCallRows(Index<ApiPartRoutines> routines)
        {
            var dst = root.list<AsmCallRow>();
            var count = routines.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(EmitCallRows(routines[i]));
            var rows = dst.ToArray();
            return rows;
        }

        public Index<AsmJmpRow> EmitJmpRows(Index<ApiPartRoutines> routines)
        {
            var dst = root.list<AsmJmpRow>();
            var count = routines.Length;
            for(var i=0; i<count; i++)
                dst.AddRange(EmitJumpRows(routines[i]));
            var rows = dst.ToArray();
            return rows;
        }

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
                var formatter = Tables.formatter<AsmJmpRow>();
                using var writer = dst.Writer();
                writer.WriteLine(formatter.FormatHeader());
                var count = src.Length;
                for(var i=0u; i<count; i++)
                    writer.WriteLine(formatter.Format(skip(src,i)));
                Wf.EmittedTable<AsmJmpRow>(flow, count, dst);
            }
        }

        public Index<AsmCallRow> EmitCallRows(ApiPartRoutines src)
        {
            var dst = Db.Table(AsmCallRow.TableId, src.Part);
            var flow = Wf.EmittingTable<AsmCallRow>(dst);
            var etl = Wf.AsmRowEtl();
            using var writer = dst.Writer();
            var calls = etl.Calls(src.Instructions());
            var view = calls.View;
            var count = view.Length;
            var formatter = Tables.formatter<AsmCallRow>();
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
                writer.WriteLine(formatter.Format(skip(view,i)));
            Wf.EmittedTable(flow, count);
            return calls;
        }

        public Index<AsmCallRow> LoadCallRows()
        {
            var files = Db.TableDir<AsmCallRow>().TopFiles.View;
            var dst = root.list<AsmCallRow>();
            var count = files.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(files,i);
                var doc = TextDocs.parse(file);
                if(doc)
                {
                    var rows = doc.Value.Rows;
                    var kRows = rows.Length;
                    for(var j = 0; j<kRows; j++)
                    {
                        ref readonly var row = ref skip(rows,j);
                        if(row.CellCount == AsmCallRow.FieldCount)
                        {
                            var cells = row.Cells.View;
                            var record = new AsmCallRow();
                            var k = 0;
                            DataParser.parse(skip(cells, k++).Text, out record.Source);
                            DataParser.parse(skip(cells, k++).Text, out record.Target);
                            DataParser.parse(skip(cells, k++).Text, out record.InstructionSize);
                            DataParser.parse(skip(cells, k++).Text, out record.TargetOffset);
                            record.Instruction = skip(cells, k++).Text;
                            DataParser.parse(skip(cells, k).Text, out record.Encoded);
                            dst.Add(record);
                        }
                    }
                }
            }
            return dst.ToArray();
        }

        public AsmRowSets<AsmMnemonic> EmitAsmRows(ApiCodeBlocks src)
        {
            try
            {
                var rowsets = EmitRowsets(src);
                var records = 0u;
                var sets = rowsets.View;
                var count = rowsets.Count;
                var flow = Wf.Running(Msg.EmittingInstructionRecords.Format(count));
                for(var i=0; i<count; i++)
                    records += Emit(skip(sets,i));

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
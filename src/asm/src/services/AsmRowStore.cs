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

        protected override void OnContextCreated()
        {

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

        public Index<AsmRow> LoadAsmRows()
        {
            var records = RecordList.create<AsmRow>(Pow2.T18);
            var paths = Db.TableDir<AsmRow>().AllFiles.View;
            var flow = Wf.Running(string.Format("Loading {0} asm recordsets", paths.Length));
            var count = paths.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(paths,i);
                var result = LoadAsmRows(path, records);
                if(result)
                    counter += result.Data;
            }

            Wf.Ran(flow, string.Format("Loaded {0} total asm instruction rows", counter));
            return records.Emit();
        }

        Outcome<Count> LoadAsmRows(FS.FilePath path, RecordList<AsmRow> dst)
        {
            var rowtype = path.FileName.WithoutExtension.Format().RightOfLast(Chars.Dot);
            var flow = Wf.Running(string.Format("Loading {0} rows from {1}", rowtype, path.ToUri()));
            var result = TextDocs.parse(path, out var doc);
            var kRows = 0;
            if(result)
            {
                var kCells = doc.Header.Labels.Count;
                if(kCells != AsmRow.FieldCount)
                    return (false,string.Format("Found {0} fields in {1} while {2} were expected", kCells, path.ToUri(), AsmRow.FieldCount));

                var rows = doc.Rows;
                kRows = rows.Length;
                for(var j=0; j<kRows; j++)
                {
                    ref readonly var src = ref skip(rows,j);
                    if(src.CellCount != AsmRow.FieldCount)
                        return (false, string.Format("Found {0} fields in {1} while {2} were expected", kCells, src, AsmRow.FieldCount));
                    var loaded = LoadAsmRow(src, out var row);
                    if(!loaded)
                    {
                        Wf.Error(loaded.Message);
                        return false;
                    }

                    dst.Add(row);
                }

                Wf.Ran(flow, string.Format("Loaded {0} {1} rows from {2}", kRows, rowtype, path.ToUri()));
            }
            else
            {
                Wf.Error(result.Message);
            }

            return (true,kRows);
        }

        Outcome LoadAsmRow(TextRow src, out AsmRow dst)
        {
            var input = src.Cells.View;
            var i = 0;
            DataParser.parse(skip(input, i++), out dst.Sequence);
            DataParser.parse(skip(input, i++), out dst.BlockAddress);
            DataParser.parse(skip(input, i++), out dst.IP);
            DataParser.parse(skip(input, i++), out dst.LocalOffset);
            DataParser.parse(skip(input, i++), out dst.GlobalOffset);
            AsmParser.parse(skip(input, i++), out dst.Mnemonic);
            AsmParser.parse(skip(input, i++), out dst.OpCode);
            DataParser.parse(skip(input, i++), out dst.Encoded);
            DataParser.parse(skip(input, i++), out dst.Statement);
            DataParser.parse(skip(input, i++), out dst.Instruction);
            DataParser.parse(skip(input, i++), out dst.CpuId);
            DataParser.parse(skip(input, i++), out dst.OpCodeId);
            return true;
        }

        public Index<AsmRow> EmitAsmRows(ApiBlockIndex src)
            => EmitAsmRows(src.Blocks);

        public Index<AsmRow> EmitAsmRows(Index<ApiCodeBlock> src)
        {
            var rows = BuildAsmRows(src);
            var rowsets = @readonly(rows.GroupBy(x => x.Mnemonic).Select(x => asm.rowset(x.Key, x.Array())).Array());
            var count = rowsets.Length;
            var etl = Wf.AsmEtl();
            for(var i=0; i<count; i++)
                etl.Emit(skip(rowsets,i));
            return rows;
        }

        public Index<AsmRow> BuildAsmRows(Index<ApiCodeBlock> src)
        {
            var view = src.View;
            var count = view.Length;
            var flow = Wf.Running(Msg.CreatingAsmRowsFromBlocks.Format(count));
            var rows = root.list<AsmRow>();
            for(var i=0u; i<count; i++)
            {
                ref readonly var block = ref skip(view,i);
                rows.AddRange(BuildAsmRows(block));
            }

            Wf.Ran(flow,Msg.CreatedAsmRowsFromBlocks.Format(rows.Count));
            return rows.ToArray();
        }

        public Index<AsmRow> BuildAsmRows(ApiBlockIndex src)
            => BuildAsmRows(src.Blocks);

        Index<AsmRow> BuildAsmRows(in ApiCodeBlock src)
        {
            var decoded = Asm.RoutineDecoder.Decode(src);
            if(decoded)
                return BuildAsmRows(src.Code, decoded.Value);
            else
            {
                Wf.Error($"Error decoding {src.OpUri}");
                return sys.empty<AsmRow>();
            }
        }

        Index<AsmRow> BuildAsmRows(in CodeBlock code, IceInstruction[] src)
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
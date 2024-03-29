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

    using static Root;
    using static core;

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

        public ReadOnlySpan<AsmDetailRow> Emit(ReadOnlySpan<ApiCodeBlock> src)
            => Emit(src, Db.TableDir<AsmDetailRow>());

        public ReadOnlySpan<AsmDetailRow> Emit(ReadOnlySpan<ApiCodeBlock> src, FS.FolderPath dst)
        {
            var rows = BuildRows(src);
            var rowsets = rows.GroupBy(x => x.Mnemonic).Select(x => asm.rowset(x.Key, x.Array())).Array().ToReadOnlySpan();
            var count = rowsets.Length;
            for(var i=0; i<count; i++)
                Emit(skip(rowsets,i), dst);
            return rows;
        }

        Index<AsmDetailRow> BuildRows(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var flow = Wf.Running(Msg.CreatingAsmRowsFromBlocks.Format(count));
            var dst = list<AsmDetailRow>();
            for(var i=0u; i<count; i++)
                dst.AddRange(BuildRows(skip(src,i)));
            Wf.Ran(flow,Msg.CreatedAsmRowsFromBlocks.Format(dst.Count));
            return dst.ToArray();
        }

        uint Emit(in AsmRowSet<AsmMnemonic> src, FS.FolderPath dst)
            => Emit(src, DetailPath(dst, src));

        uint Emit(in AsmRowSet<AsmMnemonic> src, FS.FilePath dst)
        {
            var count = src.Count;
            if(count != 0)
            {
                var flow = Wf.EmittingTable<AsmDetailRow>(dst);
                var records = span(src.Sequenced);
                var formatter = Tables.formatter<AsmDetailRow>(AsmDetailRow.RenderWidths);
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

        FS.FilePath DetailPath(FS.FolderPath dir, in AsmRowSet<AsmMnemonic> src)
            => Db.Table(dir, string.Format("{0}.{1}", Tables.identify<AsmDetailRow>(), src.Key));

        Index<AsmDetailRow> BuildRows(in ApiCodeBlock src)
        {
            var outcome = Decoder.Decode(src, out var block);
            if(outcome)
                return BuildRows(src.Code, block);
            else
            {
                Wf.Error(outcome.Message);
                return array<AsmDetailRow>();
            }
        }

        Index<AsmDetailRow> BuildRows(in CodeBlock code, IceInstruction[] src)
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
                Fill(code, new Address16(offset), bytes.Slice(offset, size), instruction, ref seek(dst,i));
                offset += size;
            }
            return buffer;
        }

        void Fill(in CodeBlock code, Address16 offset, Span<byte> encoded, in IceInstruction src, ref AsmDetailRow dst)
        {
            dst.Sequence = (uint)NextSequence;
            dst.BlockAddress = code.BaseAddress;
            dst.IP = src.IP;
            dst.LocalOffset = offset;
            dst.GlobalOffset = NextOffset;
            dst.Mnemonic = src.AsmMnemonic;
            dst.OpCode = src.Specifier.OpCode;
            dst.Encoded = new BinaryCode(encoded.TrimEnd().ToArray());
            dst.Statement = src.FormattedInstruction;
            dst.Instruction = src.Specifier.Sig.Format();
            dst.CpuId = RP.embrace(src.CpuidFeatures.Select(x => x.ToString()).Join(","));
            dst.OpCodeId = src.Code.ToString();
            if(Index.TryGetValue(src.AsmMnemonic, out var builder))
                builder.Include(dst);
            else
                Index.Add(src.AsmMnemonic, ArrayBuilder.build(dst));
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
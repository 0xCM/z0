//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public sealed class AsmEtl : AppService<AsmEtl>
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmDetailRow[] src)
            => new AsmRowSet<T>(key,src);

        [Op]
        public static LocalOffsetVector offsets(W16 w, ReadOnlySpan<AsmDetailRow> src)
        {
            var count = src.Length;
            var buffer = memory.alloc<Address16>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i).LocalOffset;
            return buffer;
        }

        public uint Emit(AsmRowSet<AsmMnemonic> src)
        {
            var count = src.Count;
            if(count != 0)
            {
                var dst = Db.Table(AsmDetailRow.TableId, src.Key.ToString());
                var flow = Wf.EmittingTable<AsmDetailRow>(dst);
                var records = span(src.Sequenced);
                var formatter = Tables.formatter<AsmDetailRow>(32);
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
        public Index<ApiInstruction> ApiInstructions(ApiCodeBlock code, IceInstruction[] src)
            => ToApiInstructions(code, src);

        public static ApiHostRoutine ApiHostRoutine(MemoryAddress @base, ApiCodeBlock code, IceInstruction[] src)
            => new ApiHostRoutine(@base, ToApiInstructions(code, src));

        [Op]
        public static Index<ApiInstruction> ToApiInstructions(ApiCodeBlock code, IceInstruction[] src)
        {
            var @base = code.BaseAddress;
            var offseq = AsmOffsetSeq.Zero;
            var count = src.Length;
            var buffer = alloc<ApiInstruction>(count);
            ref var dst = ref first(buffer);

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var len = fx.ByteLength;
                var data = span(code.Storage);
                var recoded = new ApiCodeBlock(fx.IP, code.OpUri, data.Slice((int)offseq.Offset, len).ToArray());
                seek(dst, i) = new ApiInstruction(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)len);
            }
            return buffer;
        }
    }
}
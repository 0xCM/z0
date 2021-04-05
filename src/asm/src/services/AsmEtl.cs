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

    public sealed class AsmEtl : WfService<AsmEtl>
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmRow[] src)
            => new AsmRowSet<T>(key,src);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSets<T> rowsets<T>(AsmRowSet<T>[] src)
            => new AsmRowSets<T>(src);

        public uint Emit(AsmRowSet<IceMnemonic> src)
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
        public Index<ApiInstruction> ApiInstructions(ApiCodeBlock code, IceInstruction[] src)
            => ToApiInstructions(code,src);

        public ApiInstructionBlock ApiInstructionBlock(MemoryAddress @base, ApiCodeBlock code, IceInstruction[] src)
            => new ApiInstructionBlock(@base, ApiInstructions(code, src));

        [Op]
        public static Index<ApiInstruction> ToApiInstructions(ApiCodeBlock code, IceInstruction[] src)
        {
            var @base = code.BaseAddress;
            var offseq = AsmOffsetSequence.Zero;
            var count = src.Length;
            var dst = new ApiInstruction[count];

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var len = fx.ByteLength;
                var data = span(code.Storage);
                var slice = data.Slice((int)offseq.Offset, len).ToArray();
                var recoded = new ApiCodeBlock(fx.IP, code.Uri, slice);
                dst[i] = new ApiInstruction(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)len);
            }
            return dst;
        }
    }
}
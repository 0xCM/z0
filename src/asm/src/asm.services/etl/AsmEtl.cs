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

    using F = AsmRowField;

    public sealed class AsmEtl : WfService<AsmEtl>
    {
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmRow[] src)
            => new AsmRowSet<T>(key,src);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSets<T> rowsets<T>(AsmRowSet<T>[] src)
            => new AsmRowSets<T>(src);

        /// <summary>
        /// Filters a set of instructions predicated on s specified mnemonic
        /// </summary>
        /// <param name="src">The data sourde</param>
        /// <param name="mnemonic">The mnemonic of interest</param>
        [Op]
        static ApiInstructions filter(ApiInstructions src, IceMnemonic mnemonic)
            => from a in src.Storage
                let i = a.Instruction
                where i.Mnemonic == mnemonic
                select a;


        [MethodImpl(Inline), Op]
        public Index<AsmRow> Resequence(Index<AsmRow> src)
        {
            var count = src.Length;
            ref var row = ref src.First;
            for(var i=0u; i<count;i++)
                seek(row,i).Sequence = i;
            return src;
        }

        [Op]
        public Index<AsmCallRow> Calls(ApiInstructions src)
        {
            var calls = filter(src, IceMnemonic.Call).View;
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

        [Op]
        public ApiInstructionLookup CreateLookup(ApiInstruction[] src, out ApiInstructionDuplication stats)
        {
            var count = (uint)src.Length;
            var lookup = new ApiInstructionLookup((int)count);
            var success = 0u;
            var fail = 0u;
            var source = sys.span(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var located = ref skip(source,i);
                if(lookup.TryAdd(located.IP, located))
                    success++;
                else
                    fail++;
            }

            stats = new ApiInstructionDuplication(success, fail);
            return lookup;
        }

        public uint Emit(AsmRowSet<IceMnemonic> src)
        {
            var count = src.Count;
            if(count != 0)
            {
                var dst = Db.Table(AsmRow.TableId, src.Key.ToString());
                var flow = Wf.EmittingTable<AsmRow>(dst);
                var records = span(src.Sequenced);
                var formatter = Table.dsformatter<AsmRowField>();
                var header = Table.header53<AsmRowField>();
                using var writer = dst.Writer();
                writer.WriteLine(header);
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(records,i);
                    var line = format(record, formatter).Render();
                    writer.WriteLine(line);
                }
                Wf.EmittedTable(flow, count);
            }
            return count;
        }


        [Op]
        public static ref readonly DatasetFormatter<AsmRowField> format(in AsmRow src, in DatasetFormatter<AsmRowField> dst)
        {
            dst.Append(F.Sequence, src.Sequence);
            dst.Delimit(F.BlockAddress, src.BlockAddress);
            dst.Delimit(F.IP, src.IP);
            dst.Delimit(F.GlobalOffset, src.GlobalOffset);
            dst.Delimit(F.LocalOffset, src.LocalOffset);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.Statement, src.Statement);
            dst.Delimit(F.Encoded, src.Encoded);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.OpCodeId, src.OpCodeId);
            return ref dst;
        }

        [Op]
        public Index<ApiInstruction> ApiInstructions(ApiCodeBlock code, IceInstruction[] src)
            => ToApiInstructions(code,src);

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
                dst[i] = new ApiInstruction(fx, recoded);
                offseq = offseq.AccrueOffset((uint)len);
            }
            return dst;
        }

    }
}
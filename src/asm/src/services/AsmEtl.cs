//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public sealed class AsmEtl : AppService<AsmEtl>
    {
        AsmDecoder Decoder;

        /// <summary>
        /// Describes the instructions that comprise a function
        /// </summary>
        /// <param name="src">The source function</param>
        [Op]
        public static ReadOnlySpan<AsmInstructionInfo> summarize(AsmRoutine src)
        {
            var count = src.InstructionCount;
            var buffer = new AsmInstructionInfo[count];
            var offset = 0u;
            var @base = src.BaseAddress;
            var view = src.Instructions.View;
            var dst = span(buffer);
            var counter = 0u;
            for(var i=0u; i<count; i++)
            {
                ref readonly var instruction = ref skip(view,i);
                var size = instruction.InstructionSize;

                if(src.Code.Size < offset + size)
                {
                    term.error($"Instruction size mismatch {instruction.IP} {offset} {src.Code.Size} {size}");
                    continue;
                }

                var invalid = instruction.Mnemonic == IceMnemonic.INVALID;
                if(invalid)
                    break;

                seek(dst, i) = AsmEtl.summarize(@base, instruction.Instruction, src.Code, instruction.Statment, offset);
                offset += size;
                counter++;
            }
            return slice(dst,0,counter);
        }

        public static SortedSpan<ApiCodeBlock> blocks(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            var dst = alloc<ApiCodeBlock>(count);
            var size = blocks(src, dst);
            return dst.ToSortedSpan();
        }

        [Op]
        public static ByteSize blocks(ReadOnlySpan<AsmRoutine> src, Span<ApiCodeBlock> dst)
        {
            var size = ByteSize.Zero;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                var routine = skip(src,i);
                seek(dst, i) = routine.Code;
                size += skip(dst,i).Size;
            }
            return size;
        }

        [Op]
        public static AsmInstructionInfo summarize(MemoryAddress @base, IceInstruction src, CodeBlock encoded, AsmExpr statement, uint offset)
            => new AsmInstructionInfo(@base, offset,  statement,  src.Specifier, code(encoded, offset, src.InstructionSize));

        [MethodImpl(Inline), Op]
        public static BinaryCode code(CodeBlock encoded, uint offset, byte size)
            => slice(encoded.View, offset, size).ToArray();

        [Op]
        public static AsmEncodingInfo encoding(in AsmIndex src)
            => new AsmEncodingInfo(src.Expression, src.Sig, src.OpCode, src.Encoded, AsmBitstrings.bitstring(src.Encoded));

        public SortedSpan<AsmEncodingInfo> CollectDistinctEncodings(ReadOnlySpan<AsmIndex> src)
        {
            var collecting = Wf.Running(Msg.CollectingBitstrings.Format(src.Length));
            var collected = hashset<AsmEncodingInfo>();
            var count = src.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var statement = ref skip(src,i);
                var info = AsmEtl.encoding(statement);
                if(collected.Add(info))
                    counter++;
            }

            Wf.Ran(collecting, Msg.CollectedBitstrings.Format(counter));

            return collected.Array().ToSortedSpan();
        }

        public static uint size(in ApiBlockAsm src)
        {
            var result = 0u;
            var instructions = src.Instructions;
            var count = instructions.Length;
            for(var i=0; i<count; i++)
                result += (uint)skip(instructions,i).ByteLength;
            return result;
        }

        protected override void OnInit()
        {
            Decoder = Wf.AsmDecoder();
        }

        public static AsmRoutine routine(ApiMemberCode member, AsmInstructionBlock asm)
        {
            var code = new ApiCodeBlock(member.OpUri, member.Encoded);
            return new AsmRoutine(member.OpUri, member.Method.Artifact().DisplaySig, code, member.TermCode, ToApiInstructions(code, asm));
        }

        public static ReadOnlySpan<ApiInstruction> filter(ReadOnlySpan<ApiInstruction> src, byte opcode)
        {
            var dst = list<ApiInstruction>();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(src,i);
                if(instruction.Encoded.StartsWith(opcode))
                    dst.Add(instruction);
            }
            return dst.ViewDeposited();
        }

        public static HexVector16 offsets(ReadOnlySpan<ApiInstruction> src)
        {
            var count = src.Length;
            var buffer = alloc<Hex16>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = (Hex16)skip(src, i).Offset;
            return buffer;
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmDetailRow[] src)
            => new AsmRowSet<T>(key,src);

        [Op]
        public static HexVector16 offsets(W16 w, ReadOnlySpan<AsmDetailRow> src)
        {
            var count = src.Length;
            var buffer = alloc<Hex16>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i).LocalOffset;
            return buffer;
        }

        public uint Emit(in AsmRowSet<AsmMnemonic> src, FS.FolderPath dir)
            => Emit(src, DetailPath(dir, src));

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
            var data = span(code.Storage);

            for(var i=0; i<count; i++)
            {
                var fx = skip(src, i);
                var len = fx.ByteLength;
                var recoded = new ApiCodeBlock(fx.IP, code.OpUri, data.Slice((int)offseq.Offset, len).ToArray());
                seek(dst, i) = new ApiInstruction(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)len);
            }
            return buffer;
        }

        FS.FilePath DetailPath(FS.FolderPath dir, in AsmRowSet<AsmMnemonic> src)
            => Db.Table(dir, string.Format("{0}.{1}", Tables.identify<AsmDetailRow>(), src.Key));
    }
}
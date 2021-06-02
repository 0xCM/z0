//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;
    using static core;

    [ApiHost]
    public sealed class AsmEtl : AppService<AsmEtl>
    {
        AsmDecoder Decoder;

        [Op]
        public static AsmInstructionInfo summarize(MemoryAddress @base, IceInstruction src, CodeBlock encoded, AsmStatementExpr statement, uint offset)
            => new AsmInstructionInfo(@base, offset,  statement,  src.Specifier, code(encoded, offset, src.InstructionSize));

        [MethodImpl(Inline), Op]
        public static BinaryCode code(CodeBlock encoded, uint offset, byte size)
            => slice(encoded.View, offset, size).ToArray();

        public static AsmEncodingInfo encoding(in AsmIndex src)
        {
            var content = AsmBitstrings.format(src.Encoded);
            return new AsmEncodingInfo(src.Expression, src.Sig, src.OpCode, src.Encoded, content);
        }

        public SortedSpan<AsmEncodingInfo> CollectDistinctEncodings(ReadOnlySpan<AsmIndex> src)
        {
            var collecting = Wf.Running(Msg.CollectingBitstrings.Format(src.Length));
            var collected = root.hashset<AsmEncodingInfo>();
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

        ReadOnlySpan<AsmApiStatement> BuildStatements(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            var dst = core.list<AsmApiStatement>();
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                var outcome = Decoder.Decode(block.Code, out var instructions);
                if(outcome.Fail)
                {
                    Wf.Error(outcome.Message);
                    continue;
                }

                counter += BuildStatements(block.OpUri, instructions, dst);
            }
            return dst.ViewDeposited();
        }

        uint BuildStatements(in OpUri uri, IceInstructions src, List<AsmApiStatement> dst)
        {
            var count = (uint)src.Count;
            if(count == 0)
                return  count;

            var offseq = AsmOffsetSeq.Zero;
            var view = src.View;
            var code = src.Encoded.View;
            ref readonly var i0 = ref first(view);
            var @base = i0.MemoryAddress64;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(view,i);
                var statement = new AsmApiStatement();
                var size = (uint)instruction.ByteLength;
                var recoded = new ApiCodeBlock(instruction.IP, uri, slice(code, offseq.Offset, size).ToArray());
                var apifx = new ApiInstruction(@base, instruction, recoded);
                offseq = offseq.AccrueOffset(size);

                statement.BlockAddress = @base;
                statement.OpUri = uri;
                statement.IP = instruction.IP;
                dst.Add(statement);
            }
            return (uint)count;
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
        public static unsafe uint allocTest()
        {
            const ushort BufferSize = 32;
            byte* p = stackalloc byte[BufferSize];
            p[0] = 0x10;
            p[1] = 0x20;
            p[3] = 0x30;
            p[4] = 0x40;
            uint result = (uint)(p[0] | p[1] | p[2] | p[3]);
            return result;
        }

        public static AsmRoutine routine(ApiMemberCode member, AsmInstructionBlock asm)
        {
            var code = new ApiCodeBlock(member.OpUri, member.Encoded);
            return new AsmRoutine(member.OpUri, member.Method.Artifact().DisplaySig, code, member.TermCode, ToApiInstructions(code, asm));
        }

        /// <summary>
        /// Filters a set of instructions predicated on s specified mnemonic
        /// </summary>
        /// <param name="src">The data sourde</param>
        /// <param name="mnemonic">The mnemonic of interest</param>
        [Op]
        public static ReadOnlySpan<ApiInstruction> filter(ReadOnlySpan<ApiInstruction> src, IceMnemonic mnemonic)
        {
            var dst = core.list<ApiInstruction>();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var instruction = ref skip(src,i);
                if(instruction.Mnemonic == mnemonic)
                    dst.Add(instruction);
            }
            return dst.ViewDeposited();
        }

        public static ReadOnlySpan<ApiInstruction> filter(ReadOnlySpan<ApiInstruction> src, byte opcode)
        {
            var dst = core.list<ApiInstruction>();
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

        [Op]
        public static ReadOnlySpan<ApiInstruction> instructions(ReadOnlySpan<ApiPartRoutines> src)
        {
            var dst = root.list<ApiInstruction>();
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var part = ref skip(src,i);
                var hosts = part.View;
                for(var j=0; j<hosts.Length; j++)
                {
                    ref readonly var host = ref skip(hosts, j);
                    var members = host.Members.View;
                    for(var k=0; k<members.Length; k++)
                    {
                        ref readonly var routine = ref skip(members,k);
                        var instructions = routine.Instructions.View;
                        for(var m=0; m<instructions.Length; m++)
                        {
                            ref readonly var instruction = ref skip(instructions,m);
                            dst.Add(instruction);
                        }
                    }
                }
            }
            dst.Sort();
            return dst.ViewDeposited();
        }

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmDetailRow[] src)
            => new AsmRowSet<T>(key,src);

        [Op]
        public static HexVector16 offsets(W16 w, ReadOnlySpan<AsmDetailRow> src)
        {
            var count = src.Length;
            var buffer = memory.alloc<Hex16>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i).LocalOffset;
            return buffer;
        }

        public uint Emit(in AsmRowSet<AsmMnemonic> src)
        {
            return Emit(src, DetailPath(src));
        }

        public uint Emit(in AsmRowSet<AsmMnemonic> src, FS.FolderPath dir)
        {
            return Emit(src, DetailPath(dir, src));
        }

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

        // [Op]
        // public Index<ApiInstruction> ApiInstructions(ApiCodeBlock code, IceInstruction[] src)
        //     => ToApiInstructions(code, src);

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

        FS.FilePath DetailPath(in AsmRowSet<AsmMnemonic> src)
            => Db.Table(AsmDetailRow.TableId, src.Key.ToString());

        FS.FilePath DetailPath(FS.FolderPath dir, in AsmRowSet<AsmMnemonic> src)
            => Db.Table(dir, string.Format("{0}.{1}", Tables.identify<AsmDetailRow>(), src.Key));
    }
}
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
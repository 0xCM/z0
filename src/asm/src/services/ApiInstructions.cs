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
    public readonly struct ApiInstructions
    {
        [Op]
        public static AsmInstructionInfo summarize(MemoryAddress @base, IceInstruction src, CodeBlock encoded, AsmExpr statement, uint offset)
            => new AsmInstructionInfo(@base, offset,  statement,  src.Specifier, AsmEtl.code(encoded, offset, src.InstructionSize));

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

        [Op]
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
        public static Index<ApiInstruction> from(ApiCodeBlock code, IceInstruction[] src)
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
    }
}
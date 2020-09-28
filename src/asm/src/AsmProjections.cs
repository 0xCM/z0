//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public partial class AsmProjections
    {

        [MethodImpl(Inline), Op]
        public static ApiInstruction project(MemoryAddress @base, Instruction fx, ApiCodeBlock encoded)
            => new ApiInstruction(@base,fx,encoded);

        [MethodImpl(Inline)]
        public static ApiRoutine project(MemoryAddress @base, ApiCodeBlock uriCode, Instruction[] src)
            => new ApiRoutine(@base, project(uriCode, src));

        public static ApiInstruction[] project(ApiCodeBlock code, Instruction[] src)
        {
            var @base = code.Base;
            var offseq = OffsetSequence.Zero;
            var count = src.Length;
            var dst = new ApiInstruction[count];

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var data = z.span(code.Code.Data);
                var slice = data.Slice((int)offseq.Offset, fx.ByteLength).ToArray();
                var recoded = new ApiCodeBlock(code.Uri, fx.IP, slice);
                dst[i] = AsmProjections.project(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)fx.ByteLength);
            }
            return dst;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public partial class AsmProjections
    {
        [MethodImpl(Inline)]
        public static ApiRoutineObsolete project(MemoryAddress @base, ApiCodeBlock code, Instruction[] src)
            => new ApiRoutineObsolete(@base, project(code, src));

        public static ApiInstruction[] project(ApiCodeBlock code, Instruction[] src)
        {
            var @base = code.Base;
            var offseq = OffsetSequence.Zero;
            var count = src.Length;
            var dst = new ApiInstruction[count];

            for(ushort i=0; i<count; i++)
            {
                var fx = src[i];
                var len = fx.ByteLength;
                var data = span(code.Code.Data);
                var slice = data.Slice((int)offseq.Offset, len).ToArray();
                var recoded = new ApiCodeBlock(code.Uri, fx.IP, slice);
                dst[i] = new ApiInstruction(@base, fx, recoded);
                offseq = offseq.AccrueOffset((uint)len);
            }
            return dst;
        }
    }
}
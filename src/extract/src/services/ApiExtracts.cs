//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct ApiExtracts
    {
        [Op]
        public static Index<ApiCodeBlock> parse(ReadOnlySpan<ApiExtractBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<ApiCodeBlock>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = parse(skip(src,i));
            return buffer;
        }

        [Op]
        public static ApiCodeBlock parse(in ApiExtractBlock src)
        {
            var j = terminal(src);
            var code = slice(src.View, 0, j);
            return new ApiCodeBlock(src.BaseAddress, src.Uri, code.ToArray());
        }

        /// <summary>
        /// Attempts to find the logical end of the block
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        static uint terminal(in ApiExtractBlock src)
        {
            var input = src.Encoded.View;
            var count = (uint)input.Length;
            var j = count;
            var test = 0u;
            for(var i=0u; i<count - 1; i++)
            {
                test = terminal(skip(input,i),skip(input, i+1));
                if(test !=0)
                {
                    j = i + test;
                    break;
                }
            }

            return j;
        }

        /// <summary>
        /// Tests for a terminal opcode sequence
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <returns>
        /// This follows https://github.com/microsoft/Detours/samples/disas/disas.cpp
        /// </returns>
        [MethodImpl(Inline), Op]
        static byte terminal(byte a0, byte a1)
        {
            if(0xC3 == a0 && 0x00 == a1)
                return 2;

            if (0xCB == a0 || 0xC2 == a0 || 0xCA == a0 || 0xEB == a0 || 0xE9 == a0 || 0xEA == a0)
                return 1;

            if(0xff == a0 && 0x25 == a1)
                return 2;

            return 0;
        }
    }
}
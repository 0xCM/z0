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

    [ApiHost]
    class ExtractExperiment : AppService<ExtractExperiment>
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

        [MethodImpl(Inline), Op]
        static uint terminal(ReadOnlySpan<byte> src)
        {
            var count = (uint)src.Length;
            var j = count;
            var test = 0u;
            for(var i=0u; i<count - 1; i++)
            {
                test = terminal(skip(src,i),skip(src, i+1));
                if(test !=0)
                {
                    j = i + test;
                    break;
                }
            }

            return j;
        }

        /// <summary>
        /// Attempts to find the logical end of the block
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        static uint terminal(in ApiExtractBlock src)
            => terminal(src.Encoded.View);

        /// <summary>
        /// Tests for a terminal opcode sequence
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <returns>
        /// This follows https://github.com/microsoft/Detours/samples/disas/disas.cpp, but seems to miss a lot
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

        public void ParseExtracts()
        {
            var pipe = Wf.ApiExtractPipe();
            var paths = pipe.Paths();
            var extracts = pipe.Read(paths).View;
            var parsed = parse(extracts);
            var hex = Wf.ApiHex();
            var packed = hex.BuildHexPack(parsed);
            var outfile = Db.AppLog("apihex", FS.ext("xpack"));
            hex.EmitHexPack(parsed.ToArray(), outfile);
        }
    }
}
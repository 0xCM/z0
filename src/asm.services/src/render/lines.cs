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

    partial struct AsmRender
    {
        /// <summary>
        /// Formats the instructions in a function
        /// </summary>
        /// <param name="src">The source function</param>
        /// <param name="config">An optional format configuration</param>
        [Op]
        public static ReadOnlySpan<string> lines(in AsmRoutine src, in AsmFormatConfig config)
        {
            var summaries = asm.summarize(src);
            var count = summaries.Length;
            if(count == 0)
                return default;

            var dst = span<string>(count);
            for(var i=0u; i< count; i++)
                seek(dst,i)= format(src.BaseAddress, skip(summaries,i), config);
            return dst;
        }

        /// <summary>
        /// Formats a contiguous sequence of instructions defined in an instruction list
        /// </summary>
        /// <param name="src">The instruction source</param>
        /// <param name="config">An optional format configuration</param>
        [Op]
        public static ReadOnlySpan<string> lines(in AsmFxList src, in AsmFormatConfig config)
        {
            var count = src.Count;
            if(count == 0)
                return default;

            //var config = cfg ?? AsmFormatSpec.Default;
            var summaries =  asm.summarize(src);
            var lines = span<string>(count);
            var @base = src[0].IP;

            for(var i=0u; i<(uint)count; i++)
                seek(lines,i) = format(@base, skip(summaries,i), config);
            return lines;
        }
    }
}
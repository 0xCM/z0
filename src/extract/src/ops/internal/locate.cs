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

    partial struct ApiExtracts
    {
        [Op]
        internal static CodeBlock locate(MemoryAddress address, byte[] src, int cut)
        {
            if(cut == 0)
                return new CodeBlock(address, src);
            else
            {
                Span<byte> data = src;
                var len = extractSize(data, cut, 0xC3);
                var keep = data.Slice(0, len);
                return new CodeBlock(address, keep.ToArray());
            }
        }

        [Op]
        internal static int extractSize(Span<byte> src, int maxcut, byte code)
        {
            var srcLen = src.Length;
            var cut = 0;
            if(srcLen > maxcut)
            {
                var start = srcLen - maxcut - 1;
                ref readonly var lead = ref skip(src, maxcut);
                ref readonly var current = ref lead;
                for(var i=start; i<srcLen && cut < maxcut; i++, cut++)
                {
                    current = ref skip(lead, i);
                    if(current == code)
                        break;
                }
            }
            var dstLen = src.Length - cut;
            return dstLen <= 0 ? src.Length : dstLen;
        }
    }
}
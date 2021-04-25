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

    partial struct CodeBlocks
    {
        [Op]
        public static Pair<ByteSize> sizes(ReadOnlySpan<ApiCaptureBlock> src)
        {
            var input = ByteSize.Zero;
            var output = ByteSize.Zero;
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                input += block.RawSize;
                output += block.ParsedSize;
            }
            return (input,output);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static memory;
    using static Part;

    [ApiHost]
    public readonly partial struct BitStore
    {

    }

    public sealed class BitStoreFactory : WfService<BitStoreFactory,BitStoreFactory>
    {
        public Index<CharBlock8> ByteCharBlocks(ushort start = 0, ushort end = 255)
        {
            var count = end - start + 1;
            var buffer = alloc<CharBlock8>(count);
            ref var dst = ref first(buffer);
            var k = 0;
            for(var i=start; i<=end; i++, k++)
            {
                var block = CharBlocks.alloc(n8);
                var data = block.Data;
                for(var j=0; j<8; j++)
                    seek(data,j) = bit.test(i,(byte)j).ToChar();
                block.Data.Invert();
                seek(dst,k) = block;

            }

            return buffer;
        }
    }
}
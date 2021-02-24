//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;

    partial class Hex
    {
        /// <summary>
        /// Partitions a bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
        [Op]
        public static HexIndex<Hex1>[] partition(HexIndex<Hex1> data, uint width)
        {
            var srcLength = (uint)data.Length;
            var minCount = srcLength/width;
            var rem = srcLength%width;
            var count = rem != 0 ? minCount + 1 : minCount;
            var src = data.Span;
            var dst = sys.alloc<HexIndex<Hex1>>(count);
            var dstLength = (uint)dst.Length;
            var target = span(dst);
            var last = dstLength - 1u;
            for(uint i=0, offset = 0; i<dstLength; i++, offset += width)
            {
                if(i == last && rem != 0)
                {
                    var fullBlockBuffer = alloc<Hex1>(width);
                    var fullBlock = span(fullBlockBuffer);
                    var seg = slice(src, offset, rem);
                    seg.CopyTo(fullBlock);
                    seek(target, i) = new HexIndex<Hex1>(fullBlockBuffer);
                }
                else
                {
                    var seg = slice(src, offset, width);
                    seek(target, i) = new HexIndex<Hex1>(seg.ToArray());
                }
            }
            return dst;
        }
    }
}
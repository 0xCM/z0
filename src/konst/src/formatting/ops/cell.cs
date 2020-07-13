//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Formatters
    {   
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string cell<T>(Formatter<T> formatter, in T src)            
            => formatter.Format(src);

        /// <summary>
        /// Partitions a bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
        public static HexIndex<Hex1>[] Partition(HexIndex<Hex1> data, int width)
        {
            var minCount = Math.DivRem(data.Length, width, out int remainder);
            var count = remainder != 0 ? minCount + 1 : minCount;
            var src = data.Span;
            var dst = sys.alloc<HexIndex<Hex1>>(count);
            Span<HexIndex<Hex1>> target = dst;
            var lastix = dst.Length - 1;            
            for(uint i=0, offset = 0; i< dst.Length; i++, offset += (uint)width)
            {   
                if(i == lastix && remainder != 0)
                {
                    var fullBlockBuffer = sys.alloc<Hex1>(width);
                    Span<Hex1> fullBlock = fullBlockBuffer;
                    var seg = z.slice(src, (int)offset, remainder);
                    seg.CopyTo(fullBlock);
                    seek(target, i) = new HexIndex<Hex1>(fullBlockBuffer);
                }                    
                else
                {
                    var seg = slice(src, offset, (uint)width);
                    seek(target, i) = new HexIndex<Hex1>(seg.ToArray());
                }
            }
            return dst;
        }
    }
}
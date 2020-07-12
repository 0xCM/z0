//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Populates a caller-supplied target with unpacked source bits
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The data source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void unpack<T>(T src, Span<BitState> dst)
            where T : struct
        {
            var count = size<T>();
            var data = bytes(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var u8 = ref skip(data,i);
                for(byte j=0; j<8; j++)
                    seek(dst, i+j) = test(u8,j);
            }
        }
    }
}
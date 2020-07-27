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
 
    [ApiHost]
    public readonly struct HexFormatters
    {
        /// <summary>
        /// Creates a data-oriented hex formatter
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HexDataFormatter<T> data<T>()
            where T : unmanaged
                => new HexDataFormatter<T>(HexFormatConfig.HexData);
    
        [MethodImpl(Inline), Op]
        public static HexDataFormatter data(int bpl = 20, bool labels = true)
            => new HexDataFormatter(new HexLineConfig(bpl, labels));
    }
}

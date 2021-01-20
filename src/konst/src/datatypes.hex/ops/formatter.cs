//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static HexDataFormatter formatter(MemoryAddress? @base = null, ushort bpl = 20, bool labels = true)
            => new HexDataFormatter(new HexLineConfig(bpl, labels), @base);

        /// <summary>
        /// Creates a <see cref='HexFormatter<T>'/> for primitive numeric types
        /// </summary>
        /// <typeparam name="T">The primitive numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HexFormatter<T> formatter<T>()
            where T : unmanaged
                => new HexFormatter<T>(SystemHexFormatters.create<T>());
    }
}
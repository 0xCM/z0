//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial struct Formatters
    {
        /// <summary>
        /// Creates a <see cref='HexFormatter<T>'/> for primitive numeric types
        /// </summary>
        /// <typeparam name="T">The primitive numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static HexFormatter<T> hex<T>()
            where T : unmanaged
                => new HexFormatter<T>(SystemHexFormatters.create<T>());
    }
}
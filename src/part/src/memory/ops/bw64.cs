//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Conforms a source value as needed to yield a value of bit-width 64
        /// </summary>
        /// <param name="src">The input value</param>
        /// <typeparam name="T">The input type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ulong bw64<T>(T src)
            where T : unmanaged
        {
            if(bitwidth<T>() == 8)
                return uint8(src);
            if(bitwidth<T>() == 16)
                return uint16(src);
            else if(bitwidth<T>() == 32)
                return uint32(src);
            else
                return uint64(src);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;

    partial struct As
    {
        /// <summary>
        /// Reads a T-cell from a bytespan
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="T"></typeparam>
        
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T read<T>(ReadOnlySpan<byte> src)
            where T : struct
                => Read<T>(src);        
    }
}
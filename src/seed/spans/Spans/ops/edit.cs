//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    

    using static System.Runtime.InteropServices.MemoryMarshal;    
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial class Spans
    {
        /// <summary>
        /// Presents a readonly reference as reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        internal static ref T edit<T>(in T src)
            => ref AsRef(in src);
    }
}
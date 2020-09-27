//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public partial class Bit
    {
        /// <summary>
        /// Wraps a bitview around a generic reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The generic type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitEdit<T> editor<T>(ref T src)
            where T : unmanaged
                => new BitEdit<T>(ref src);
    }
}
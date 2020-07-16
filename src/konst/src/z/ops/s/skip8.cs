//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct z
    {
        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte skip8<T>(in T src, uint count)
            => ref Add(ref edit<T,byte>(src), (int)count);
    }
}
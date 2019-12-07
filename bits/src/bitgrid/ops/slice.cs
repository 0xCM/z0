//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class BitGrid
    {        

        /// <summary>
        /// Extracts a sequence of bits
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The offset</param>
        /// <param name="index">The bit count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> slice<T>(BitGrid32<T> g, int index, int length)
            where T : unmanaged
                => generic<T>(gbits.extract(g.Data, index*length, length));

        /// <summary>
        /// Extracts a sequence of bits
        /// </summary>
        /// <param name="g">The source grid</param>
        /// <param name="index">The offset</param>
        /// <param name="index">The bit count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> slice<T>(BitGrid64<T> g, int index, int length)
            where T : unmanaged
                => generic<T>(gbits.extract(g.Data, index*length, length));

    }
}
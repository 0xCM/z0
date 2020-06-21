// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        /// <summary>
        /// Deposits a source value, identified by pointer and offset, into a target reference
        /// </summary>
        /// <param name="pSrc">The data source</param>
        /// <param name="offset">The value offset</param>
        /// <param name="dst">The receiving reference</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public unsafe static ref T read<T>(T* pSrc, int offset, ref T dst)
            where T : unmanaged
                => ref Imagine.read(pSrc,offset, ref dst);

        /// <summary>
        /// Deposits a range of source values into a target reference
        /// </summary>
        /// <param name="pSrc">The data source</param>
        /// <param name="offset">The value offset</param>
        /// <param name="dst">The receiving reference</param>
        /// <param name="count">The number of values to extract/deposit</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void read<T>(T* pSrc, int offset, ref T dst, int count)
            where T : unmanaged
                => Imagine.read(pSrc,offset, ref dst, count);
    }
}
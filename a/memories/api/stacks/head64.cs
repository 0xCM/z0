//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Stacked
    {
        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref MemStack64 src)
            => ref src.X0;

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref MemStack128 src)
            => ref src.X0;

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref MemStack256 src)
            => ref head64(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref MemStack512 src)
            => ref head64(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref MemStack1024 src)
            => ref head64(ref src.X0);
    }
}
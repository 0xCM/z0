//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class MemBlocks
    {
        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong first64(ref Block8 src)
            => ref u64(src);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong first64(ref Block16 src)
            => ref u64(src);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong first64(ref Block32 src)
            => ref u64(src);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong first64(ref Block64 src)
            => ref u64(src);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong first64(ref Block128 src)
            => ref u64(src);
    }
}
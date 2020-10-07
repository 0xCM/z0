//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Stacks
    {
        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref BitBlock64 src)
            => ref u64(src);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref BitBlock128 src)
            => ref u64(src);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref BitBlock256 src)
            => ref u64(src);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref BitBlock512 src)
            => ref head64(ref src.X0);

        /// <summary>
        /// Presents the leading source storage cell as reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline), Op]
        public static ref ulong head64(ref BitStack1024 src)
            => ref head64(ref src.X0);
    }
}
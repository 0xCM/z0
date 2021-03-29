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
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T first<T>(ref Block8 src)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T first<T>(ref Block16 src)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T first<T>(ref Block32 src)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T first<T>(ref Block64 src)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T first<T>(ref Block128 src)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));
    }
}
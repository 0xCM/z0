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

    partial class MemoryStacks
    {
        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T head<T>(ref BitBlock64 src)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T head<T>(ref BitBlock128 src, T t = default)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T head<T>(ref BitBlock256 src, T t = default)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T head<T>(ref BitBlock512 src, T t = default)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T head<T>(ref BitBlock1024 src, T t = default)
            where T : unmanaged
                => ref @as<ulong,T>(u64(src));
    }
}
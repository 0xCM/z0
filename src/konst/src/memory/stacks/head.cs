//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Stacked;

    partial class Stacks
    {
        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T head<T>(ref BitBlock64 src, T t = default)
            where T : unmanaged
                => ref z.@as<ulong,T>(z.u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T head<T>(ref BitBlock128 src, T t = default)
            where T : unmanaged
                => ref z.@as<ulong,T>(z.u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T head<T>(ref BitBlock256 src, T t = default)
            where T : unmanaged
                => ref z.@as<ulong,T>(z.u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T head<T>(ref BitBlock512 src, T t = default)
            where T : unmanaged
                => ref z.@as<ulong,T>(z.u64(src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T head<T>(ref BitStack1024 src, T t = default)
            where T : unmanaged
                => ref z.@as<ulong,T>(z.u64(src));

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack2 src)
            => ref src.C0;

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack4 src)
            => ref z.c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack8 src)
            => ref z.c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack16 src)
            => ref z.c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack32 src)
            => ref z.c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack64 src)
            => ref z.c16(src);
    }
}
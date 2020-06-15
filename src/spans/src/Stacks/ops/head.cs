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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref MemStack64 src, T t = default)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref MemStack128 src, T t = default)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref MemStack256 src, T t = default)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref MemStack512 src, T t = default)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Presents the leading source storage cell as a generic reference
        /// </summary>
        /// <param name="src">The source storage</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T head<T>(ref MemStack1024 src, T t = default)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

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
            => ref head(ref src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack8 src)
            => ref head(ref src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack16 src)
            => ref head(ref src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack32 src)
            => ref head(ref src.C0);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char head(ref CharStack64 src)
            => ref head(ref src.C0);
    }
}
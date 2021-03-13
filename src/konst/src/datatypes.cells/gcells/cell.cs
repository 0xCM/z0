//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static Cells;
    using static memory;

    partial struct gcells
    {
        /// <summary>
        /// Creates a fixed-type value of parametric type
        /// </summary>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static F alloc<F>()
            where F : unmanaged, IDataCell
                => default(F);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell8 cell8<T>(T src)
            where T : unmanaged
                => new Cell8(@as<T,byte>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell16 cell16<T>(T src)
            where T : unmanaged
                => new Cell16(@as<T,ushort>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell32 cell32<T>(T src)
            where T : unmanaged
                => new Cell32(@as<T,uint>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell64 cell64<T>(T src)
            where T : unmanaged
                => new Cell64(@as<T,ulong>(src));

        /// <summary>
        /// Presents a 128-bit vector as a 128-bit cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Cell128 cell128<T>(in Vector128<T> src)
            where T : unmanaged
                => ref Cells.from<Vector128<T>,Cell128>(src);

        /// <summary>
        /// Presents a 256-bit vector as a 256-bit cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Cell256 cell256<T>(in Vector256<T> src)
            where T : unmanaged
                => ref Cells.from<Vector256<T>,Cell256>(src);

        /// <summary>
        /// Presents a 512-bit vector as a 512-bit cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Cell512 cell512<T>(in Vector512<T> src)
            where T : unmanaged
                => ref Cells.from<Vector512<T>,Cell512>(src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static core;

    partial struct gcpu
    {
        /// <summary>
        /// Returns a readonly reference to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<T> src)
            where T : unmanaged
                => ref gcpu.vref(ref edit(src));

        /// <summary>
        /// Returns a readonly reference to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<T> src)
            where T : unmanaged
                => ref gcpu.vref(ref edit(src));

        /// <summary>
        /// Returns a readonly reference to the leading component of the source
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<T> src)
            where T : unmanaged
                => ref gcpu.vref(ref edit(src));

        /// <summary>
        /// Presents a readonly reference to 128-bit S-vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The vector cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T vread<S,T>(in Vector128<S> src)
            where S : unmanaged
                => ref @as<Vector128<S>,T>(edit(src));

        /// <summary>
        /// Presents a readonly reference to 256-bit S-vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The vector cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T vread<S,T>(in Vector256<S> src)
            where S : unmanaged
                => ref @as<Vector256<S>,T>(edit(src));

        /// <summary>
        /// Presents a readonly reference to 512-bit S-vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The vector cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T vread<S,T>(in Vector512<S> src)
            where S : unmanaged
                => ref @as<Vector512<S>,T>(edit(src));

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<byte> src)
            => ref vread<byte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<sbyte> src)
            => ref vread<sbyte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<short> src)
            => ref vread<short,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<ushort> src)
            => ref vread<ushort,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<int> src)
            => ref vread<int,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<uint> src)
            => ref vread<uint,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<long> src)
            => ref vread<long,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<ulong> src)
            => ref vread<ulong,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<float> src)
            => ref vread<float,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector128<double> src)
            => ref vread<double,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<byte> src)
            => ref vread<byte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<sbyte> src)
            => ref vread<sbyte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<short> src)
            => ref vread<short,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<ushort> src)
            => ref vread<ushort,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<int> src)
            => ref vread<int,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<uint> src)
            => ref vread<uint,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<long> src)
            => ref vread<long,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<ulong> src)
            => ref vread<ulong,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<float> src)
            => ref vread<float,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector256<double> src)
            => ref vread<double,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<byte> src)
            => ref vread<byte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<sbyte> src)
            => ref vread<sbyte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<short> src)
            => ref vread<short,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<ushort> src)
            => ref vread<ushort,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<int> src)
            => ref vread<int,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<uint> src)
            => ref vread<uint,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<long> src)
            => ref vread<long,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<ulong> src)
            => ref vread<ulong,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<float> src)
            => ref vread<float,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly T vread<T>(in Vector512<double> src)
            => ref vread<double,T>(src);
    }
}
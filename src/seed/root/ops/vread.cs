//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class Root
    {        
        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.U8))]
        public static ref readonly T vread<T>(in Vector128<byte> src)
            => ref vread<byte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.I8))]
        public static ref readonly T vread<T>(in Vector128<sbyte> src)
            => ref vread<sbyte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.I16))]
        public static ref readonly T vread<T>(in Vector128<short> src)
            => ref vread<short,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.U16))]
        public static ref readonly T vread<T>(in Vector128<ushort> src)
            => ref vread<ushort,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.I32))]
        public static ref readonly T vread<T>(in Vector128<int> src)
            => ref vread<int,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.U32))]
        public static ref readonly T vread<T>(in Vector128<uint> src)
            => ref vread<uint,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.I64))]
        public static ref readonly T vread<T>(in Vector128<long> src)
            => ref vread<long,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.U64))]
        public static ref readonly T vread<T>(in Vector128<ulong> src)
            => ref vread<ulong,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.F32))]
        public static ref readonly T vread<T>(in Vector128<float> src)
            => ref vread<float,T>(src);

        /// <summary>
        /// Presents a readonly reference to 128-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.F64))]
        public static ref readonly T vread<T>(in Vector128<double> src)
            => ref vread<double,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.U8))]
        public static ref readonly T vread<T>(in Vector256<byte> src)
            => ref vread<byte,T>(src);

        /// <summary>
        /// Presents a readonly reference to 256-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.I8))]
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
        [MethodImpl(Inline), Op, Closures(AllNumeric& (~NumericKind.U32))]
        public static ref readonly T vread<T>(in Vector512<uint> src)
            => ref vread<uint,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric& (~NumericKind.I64))]
        public static ref readonly T vread<T>(in Vector512<long> src)
            => ref vread<long,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric& (~NumericKind.U64))]
        public static ref readonly T vread<T>(in Vector512<ulong> src)
            => ref vread<ulong,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric& (~NumericKind.F32))]
        public static ref readonly T vread<T>(in Vector512<float> src)
            => ref vread<float,T>(src);

        /// <summary>
        /// Presents a readonly reference to 512-bit vector as a readonly T-reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric & (~NumericKind.F64))]
        public static ref readonly T vread<T>(in Vector512<double> src)
            => ref vread<double,T>(src);            
    }
}
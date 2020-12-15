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
    using static z;

    partial struct z
    {
        /// <summary>
        /// Hydrates a 128-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector128<T> vcover<S,T>(W128 w, ref S src)
            where T : unmanaged
                => ref @as<S,Vector128<T>>(src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector256<T> vcover<S,T>(W256 w, ref S src)
            where T : unmanaged
                => ref @as<S,Vector256<T>>(src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector512<T> vcover<S,T>(W512 w, ref S src)
            where T : unmanaged
                => ref @as<S,Vector512<T>>(src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref byte src)
            where T : unmanaged
                => ref vcover<byte,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref sbyte src)
            where T : unmanaged
                => ref vcover<sbyte,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref short src)
            where T : unmanaged
                => ref vcover<short,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref ushort src)
            where T : unmanaged
                => ref vcover<ushort,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref int src)
            where T : unmanaged
                => ref vcover<int,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref uint src)
            where T : unmanaged
                => ref vcover<uint,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref long src)
            where T : unmanaged
                => ref vcover<long,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref ulong src)
            where T : unmanaged
                => ref vcover<ulong,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref bool src)
            where T : unmanaged
                => ref vcover<bool,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref char src)
            where T : unmanaged
                => ref vcover<char,T>(w, ref src);

        /// <summary>
        /// Covers a 16-byte segment with a 128-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vcover<T>(W128 w, ref decimal src)
            where T : unmanaged
                => ref vcover<decimal,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref byte src)
            where T : unmanaged
                => ref vcover<byte,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref sbyte src)
            where T : unmanaged
                => ref vcover<sbyte,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref short src)
            where T : unmanaged
                => ref vcover<short,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref ushort src)
            where T : unmanaged
                => ref vcover<ushort,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref int src)
            where T : unmanaged
                => ref vcover<int,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref uint src)
            where T : unmanaged
                => ref vcover<uint,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref long src)
            where T : unmanaged
                => ref vcover<long,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref ulong src)
            where T : unmanaged
                => ref vcover<ulong,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref bool src)
            where T : unmanaged
                => ref vcover<bool,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref char src)
            where T : unmanaged
                => ref vcover<char,T>(w, ref src);

        /// <summary>
        /// Covers a 32-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vcover<T>(W256 w, ref decimal src)
            where T : unmanaged
                => ref vcover<decimal,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref byte src)
            where T : unmanaged
                => ref vcover<byte,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref sbyte src)
            where T : unmanaged
                => ref vcover<sbyte,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref short src)
            where T : unmanaged
                => ref vcover<short,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref ushort src)
            where T : unmanaged
                => ref vcover<ushort,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref int src)
            where T : unmanaged
                => ref vcover<int,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref uint src)
            where T : unmanaged
                => ref vcover<uint,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref long src)
            where T : unmanaged
                => ref vcover<long,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref ulong src)
            where T : unmanaged
                => ref vcover<ulong,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref bool src)
            where T : unmanaged
                => ref vcover<bool,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref char src)
            where T : unmanaged
                => ref vcover<char,T>(w, ref src);

        /// <summary>
        /// Covers a 64-byte segment with a 256-bit T-vector
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vcover<T>(W512 w, ref decimal src)
            where T : unmanaged
                => ref vcover<decimal,T>(w, ref src);

        /// <summary>
        /// 8x16w -> 16x8w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcover(Vector128<ushort> src, out Vector128<byte> dst)
            => dst = v8u(vor(vsll(src,8),src));

        /// <summary>
        /// 16x16w -> 32x8w
        /// [0, 1, ... 14, 15] -> [0, 0, 1, 1, ... 14, 14, 15, 15]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcover(Vector256<ushort> src, out Vector256<byte> dst)
            => dst = v8u(vor(vsll(src,8),src));

        /// <summary>
        /// 4x8w -> 8x16w
        /// [0, 1, 2, 3] -> [0, 0, 1, 1, 2, 2, 3, 3]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcover(Vector128<uint> src, out Vector128<ushort> dst)
            => dst = v16u(vor(vsll(src,16),src));

        /// <summary>
        /// 8x32w -> 16x16w
        /// [0, 1, 2, 3, 4, 5, 6, 7] -> [0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcover(Vector256<uint> src, out Vector256<ushort> dst)
             => dst = v16u(vor(vsll(src,16),src));

        /// <summary>
        /// 2x64w -> 4x32w
        /// [0, 1] -> [0, 0, 1, 1]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcover(Vector128<ulong> src, out Vector128<uint> dst)
            => dst = v32u(vor(vsll(src,32),src));

        /// <summary>
        /// 4x64w -> 8x32w
        /// [0, 1, 2, 3] -> [0, 0, 1, 1, 2, 2, 3, 3]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcover(Vector256<ulong> src, out Vector256<uint> dst)
            => dst = v32u(vor(vsll(src,32),src));

        /// <summary>
        /// 4x32w -> 16x8w
        /// [0, 1, 2, 3] -> [0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcover(Vector128<uint> src, out Vector128<byte> dst)
            => dst = vcover(v16u(vxor(vsll(src,16), src)), out dst);

        /// <summary>
        /// 8x32w -> 32x8w
        /// [0, 1, 2, 3, 4, 5, 6, 7] -> [0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcover(Vector256<uint> src, out Vector256<byte> dst)
            => dst = vcover(v16u(vxor(vsll(src,16), src)), out dst);

        /// <summary>
        /// 2x64w -> 16x8w
        /// [0,1] -> [0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcover(Vector128<ulong> src, out Vector128<byte> dst)
            => dst = vcover(v32u(vxor(vsll(src,32), src)), out dst);

        /// <summary>
        /// 4x64w -> 32x8w
        /// [0, 1, 2, 3] -> [0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3]
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcover(Vector256<ulong> src, out Vector256<byte> dst)
            => dst = vcover(v32u(vxor(vsll(src,32), src)), out dst);
    }
}
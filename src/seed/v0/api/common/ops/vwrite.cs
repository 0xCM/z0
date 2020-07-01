//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static Konst;

    partial struct V0
    {                        
        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref byte src)
            where T : unmanaged
                => ref vwrite<byte,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref sbyte src)
            where T : unmanaged
                => ref vwrite<sbyte,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref short src)
            where T : unmanaged
                => ref vwrite<short,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref ushort src)
            where T : unmanaged
                => ref vwrite<ushort,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref int src)
            where T : unmanaged
                => ref vwrite<int,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref uint src)
            where T : unmanaged
                => ref vwrite<uint,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref long src)
            where T : unmanaged
                => ref vwrite<long,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref ulong src)
            where T : unmanaged
                => ref vwrite<ulong,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref bool src)
            where T : unmanaged
                => ref vwrite<bool,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref char src)
            where T : unmanaged
                => ref vwrite<char,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector128<T> vwrite<T>(W128 w, ref decimal src)
            where T : unmanaged
                => ref vwrite<decimal,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref byte src)
            where T : unmanaged
                => ref vwrite<byte,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref sbyte src)
            where T : unmanaged
                => ref vwrite<sbyte,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref short src)
            where T : unmanaged
                => ref vwrite<short,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref ushort src)
            where T : unmanaged
                => ref vwrite<ushort,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref int src)
            where T : unmanaged
                => ref vwrite<int,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref uint src)
            where T : unmanaged
                => ref vwrite<uint,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref long src)
            where T : unmanaged
                => ref vwrite<long,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref ulong src)
            where T : unmanaged
                => ref vwrite<ulong,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref bool src)
            where T : unmanaged
                => ref vwrite<bool,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref char src)
            where T : unmanaged
                => ref vwrite<char,T>(w, ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector256<T> vwrite<T>(W256 w, ref decimal src)
            where T : unmanaged
                => ref vwrite<decimal,T>(w, ref src);


        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref byte src)
            where T : unmanaged
                => ref vwrite<byte,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref sbyte src)
            where T : unmanaged
                => ref vwrite<sbyte,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref short src)
            where T : unmanaged
                => ref vwrite<short,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref ushort src)
            where T : unmanaged
                => ref vwrite<ushort,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref int src)
            where T : unmanaged
                => ref vwrite<int,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref uint src)
            where T : unmanaged
                => ref vwrite<uint,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref long src)
            where T : unmanaged
                => ref vwrite<long,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref ulong src)
            where T : unmanaged
                => ref vwrite<ulong,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref bool src)
            where T : unmanaged
                => ref vwrite<bool,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref char src)
            where T : unmanaged
                => ref vwrite<char,T>(w, ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from a reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref Vector512<T> vwrite<T>(W512 w, ref decimal src)
            where T : unmanaged
                => ref vwrite<decimal,T>(w, ref src);

        /// <summary>
        /// Hydrates a 128-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector128<T> vwrite<S,T>(W128 w, ref S src)
            where T : unmanaged
                => ref Root.write<S,Vector128<T>>(ref src);

        /// <summary>
        /// Hydrates a 256-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector256<T> vwrite<S,T>(W256 w, ref S src)
            where T : unmanaged
                => ref Root.write<S,Vector256<T>>(ref src);

        /// <summary>
        /// Hydrates a 512-bit T-vector from an S-reference
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The data source</param>
        /// <typeparam name="S">The source reference type</typeparam>
        /// <typeparam name="T">The target vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref Vector512<T> vwrite<S,T>(W512 w, ref S src)
            where T : unmanaged
                => ref Root.write<S,Vector512<T>>(ref src);
    }
}
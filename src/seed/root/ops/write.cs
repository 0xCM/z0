// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static As;

    partial class Root
    {
        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref sbyte src)
            => ref @as<sbyte,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref byte src)
            => ref @as<byte,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref short src)
            => ref @as<short,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref ushort src)
            => ref @as<ushort,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref int src)
            => ref @as<int,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref uint src)
            => ref @as<uint,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref long src)
            => ref @as<long,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref bool src)
            => ref @as<bool,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref char src)
            => ref @as<char,T>(ref src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref decimal src)
            => ref @as<decimal,T>(ref src);


        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref sbyte src, int offset)
            => ref write<sbyte,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref byte src, int offset)
            => ref write<byte,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref short src, int offset)
            => ref write<short,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref ushort src, int offset)
            => ref write<ushort,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref int src, int offset)
            => ref write<int,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref uint src, int offset)
            => ref write<uint,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref long src, int offset)
            => ref write<long,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref bool src, int offset)
            => ref write<bool,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref char src, int offset)
            => ref write<char,T>(ref src, offset);

        /// <summary>
        /// Hydrates a T-cell from a reference after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of source elements to skip</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref decimal src, int offset)
            => ref write<decimal,T>(ref src, offset);
    }
}
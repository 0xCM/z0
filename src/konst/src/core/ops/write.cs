// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Hydrates a T-cell from an S-reference after skipping a specified number of S-cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The number of S-cells to skip</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T write<S,T>(ref S src, int offset)        
            => ref @as<S,T>(add(src, offset));        
            
        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref sbyte src)
            => ref @as<sbyte,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref byte src)
            => ref @as<byte,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref short src)
            => ref @as<short,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref ushort src)
            => ref @as<ushort,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref int src)
            => ref @as<int,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref uint src)
            => ref @as<uint,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref long src)
            => ref @as<long,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref bool src)
            => ref @as<bool,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref char src)
            => ref @as<char,T>(src);

        /// <summary>
        /// Hydrates a T-cell from a reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T write<T>(ref decimal src)
            => ref @as<decimal,T>(src);

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
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
       /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in byte src)        
            => ref read<byte,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in sbyte src)        
            => ref read<sbyte,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in short src)        
            => ref read<short,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in ushort src)        
            => ref read<ushort,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in int src)        
            => ref read<int,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in uint src)        
            => ref read<uint,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in long src)        
            => ref read<long,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in ulong src)        
            => ref read<ulong,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in float src)        
            => ref read<float,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in double src)        
            => ref read<double,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in bool src)        
            => ref read<bool,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in char src)        
            => ref read<char,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in decimal src)        
            => ref read<decimal,T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in byte src, int offset)        
            => ref read<byte,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in sbyte src, int offset)        
            => ref read<sbyte,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in short src, int offset)        
            => ref read<short,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in ushort src, int offset)        
            => ref read<ushort,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in int src, int offset)        
            => ref read<int,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in uint src, int offset)        
            => ref read<uint,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in long src, int offset)        
            => ref read<long,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in ulong src, int offset)        
            => ref read<ulong,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in float src, int offset)        
            => ref read<float,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in double src, int offset)        
            => ref read<double,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in bool src, int offset)        
            => ref read<bool,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in char src, int offset)        
            => ref read<char,T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T read<T>(in decimal src, int offset)        
            => ref read<decimal,T>(src, offset);            
    }
}
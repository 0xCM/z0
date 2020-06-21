// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in byte src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in sbyte src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in short src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ushort src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in int src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in uint src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in long src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ulong src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in float src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in double src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in bool src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in char src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in decimal src)        
            => ref Imagine.read<T>(src);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in byte src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in sbyte src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in short src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ushort src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in int src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in uint src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in long src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in ulong src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in float src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in double src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in bool src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in char src, int offset)        
            => ref Imagine.read<T>(src, offset);

        /// <summary>
        /// Reads a T-cell from a specified data source after skipping a specified number of source cells
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T read<T>(in decimal src, int offset)        
            => ref Imagine.read<T>(src, offset);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    partial class Fixed
    {
        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed64 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed128 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed256 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed512 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed1024 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed2048 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed4096 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed128 src)
            => ref src.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed256 src)
            => ref src.X0.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed512 src)
            => ref src.X0.X0.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed1024 src)
            => ref src.X0.X0.X0.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed2048 src)
            => ref src.X0.X0.X0.X0.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed4096 src)
            => ref src.X0.X0.X0.X0.X0.X0;
    }
}

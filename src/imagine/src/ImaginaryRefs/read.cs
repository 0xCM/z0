//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct Imagine
    {
        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly byte read<T>(W8 w, in T src)
            => ref As<T,byte>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ushort read<T>(W16 w, in T src)
            => ref As<T,ushort>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly uint read<T>(W32 w, in T src)
            => ref As<T,uint>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a readonly uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly ulong read<T>(W64 w, in T src)
            => ref As<T,ulong>(ref AsRef(in src));
    }
}
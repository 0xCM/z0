//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.InteropServices.MemoryMarshal;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Interprets a readonly generic reference as a uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte recover<T>(W8 w, in T src)
            => ref As<T,byte>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort recover<T>(W16 w, in T src)
            => ref As<T,ushort>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint recover<T>(W32 w, in T src)
            => ref As<T,uint>(ref AsRef(in src));

        /// <summary>
        /// Interprets a readonly generic reference as a uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong recover<T>(W64 w, in T src)
            => ref As<T,ulong>(ref AsRef(in src));
    }
}
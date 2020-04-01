//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using static Seed;

    partial class Core
    {
        /// <summary>
        /// Presents generic reference as a generic pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)pvoid(ref src);

        /// <summary>
        /// Presents a generic reference r:T as a generic pointer p:T
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        /// <typeparam name="P">The target pointer type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe P* ptr<T,P>(ref T r)
            where T : unmanaged
            where P : unmanaged
                => (P*)Unsafe.AsPointer(ref r);

        /// <summary>
        /// Presents generic reference as a generic pointer displaced by an element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* ptr<T>(ref T src, int offset)
            where T : unmanaged
                => (T*)Unsafe.AsPointer(ref seek(ref src, offset));

        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline)]
        static unsafe void* pvoid<T>(ref T src)
            => Unsafe.AsPointer(ref src); 
    }
}
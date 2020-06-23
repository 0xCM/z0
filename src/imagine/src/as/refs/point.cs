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

    using static AsInternal;
    
    partial struct As
    {
        [MethodImpl(Inline), Op]
        public static IntPtr intptr(long i)
            => new IntPtr(i);

        [MethodImpl(Inline), Op]
        public static unsafe IntPtr intptr(void* p)
            => new IntPtr(p);

        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe void* pvoid<T>(in T src)
            => AsPointer(ref edit(src)); 

        /// <summary>
        /// Presents a generic reference as a generic pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* point<T>(in T src)
            where T : unmanaged
                => ptr(ref edit(in src));

        /// <summary>
        /// Presents a generic reference as a generic pointer displaced by an element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* point<T>(in T src, int offset)
            where T : unmanaged
                => ptr(ref edit(skip(src, offset)));


        /// <summary>
        /// Presents a generic reference r:T as a generic pointer p:T
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        /// <typeparam name="P">The target pointer type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe P* point<T,P>(in T r)
            where T : unmanaged
            where P : unmanaged
                => (P*)AsPointer(ref edit(r));

        /// <summary>
        /// Presents a generic reference as a byte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe byte* pbyte<T>(in T r)
            where T : unmanaged
                => ptr<T,byte>(ref edit(r));
    }
}
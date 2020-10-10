//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe T* gptr<T>(in T src)
            where T : unmanaged
                => As.gptr(src);

        /// <summary>
        /// Presents a readonly reference to an unmanaged value as a pointer displaced
        /// by a specified element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* gptr<T>(in T src, int offset)
            where T : unmanaged
                => As.gptr(src,offset);

        [MethodImpl(Inline)]
        public unsafe static T* gptr<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => As.gptr(src);

        /// <summary>
        /// Presents a generic reference r:T as a generic pointer p:T
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        /// <typeparam name="P">The target pointer type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* gptr<S,T>(in S src)
            where S : unmanaged
            where T : unmanaged
                => As.gptr<S,T>(src);
    }
}
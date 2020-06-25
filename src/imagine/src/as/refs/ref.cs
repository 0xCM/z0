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

    partial struct As
    {
        /// <summary>
        /// Presents a pointer as a reference
        /// </summary>
        /// <param name="ptr">The source pointer</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ref T @ref<T>(T* ptr)            
            where T : unmanaged
                => ref AsRef<T>(ptr);

        [MethodImpl(Inline)]
        public static unsafe ref T @ref<S,T>(S* pSrc)            
            where S : unmanaged
                => ref @as<S,T>(ref @ref<S>(pSrc));
                
        /// <summary>
        /// Presents a T-reference as a byte reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte @ref<T>(W8 w, ref T src)
            => ref As<T,byte>(ref src);
    }
}
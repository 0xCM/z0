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

    partial struct z
    {
        /// <summary>
        /// Creates a reference to a string
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe StringRef @ref(string src)
            => new StringRef((ulong)pchar(src), (uint)src.Length);

        /// <summary>
        /// Creates a character reference from a <see cref='StringRef'/?
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static ref char @ref(in StringRef src)
            => ref @as<ulong,char>(address(src));

        /// <summary>
        /// Presents a pointer as a reference
        /// </summary>
        /// <param name="ptr">The source pointer</param>
        /// <typeparam name="T">The reference type</typeparam>
        /// <remarks>For all T, effects: mov rax,rcx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ref T @ref<T>(T* ptr)            
            where T : unmanaged
                => ref AsRef<T>(ptr);            

        /// <summary>
        /// Presents a void pointer as a reference
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ref T @ref<T>(void* pSrc)
            => ref AsRef<T>(pSrc);

        /// <summary>
        /// Returns a reference to an identified location
        /// </summary>
        /// <param name="src">The source address</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ref T @ref<T>(MemoryAddress src)
            => ref AsRef<T>((void*)src.Location);

        /// <summary>
        /// Presents an S-pointer as a T-reference
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ref T @ref<S,T>(S* pSrc)            
            where S : unmanaged
                => ref @as<S,T>(@ref<S>(pSrc));    
    }
}
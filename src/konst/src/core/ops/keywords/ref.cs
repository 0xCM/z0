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

    partial struct core
    {
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
        /// Creates a reference to a string
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe StringRef @ref(string src)
            => new StringRef((ulong)pchar(src), src.Length);

        /// <summary>
        /// Captures a parametric reference to cell content beginning at a specified address
        /// </summary>
        /// <param name="src">The content address</param>
        /// <param name="count">The content cell count</param>
        /// <typeparam name="T">The content type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Ref<T> @ref<T>(MemoryAddress src, uint count)
            => new Ref<T>(@ref((void*)src, size<T>(count)));


        /// <summary>
        /// Captures an untyped sized reference
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        /// <param name="size">The data size</param>
        [MethodImpl(Inline)]
        public static unsafe Ref @ref(void* pSrc, uint size)
            => new Ref((ulong)pSrc, size);

        /// <summary>
        /// Captures an untyped sized reference
        /// </summary>
        /// <param name="src">The reference address</param>
        /// <param name="size">The data size</param>
        [MethodImpl(Inline)]
        public static Ref @ref(MemoryAddress src, uint size)
            => new Ref(src, size);

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
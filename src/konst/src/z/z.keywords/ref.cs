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
        /// Presents a T-reference as a byte reference and effects mov rax,rdx for all T
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <remarks>For all T, effects: mov rax,rdx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte @ref<T>(W8 w, ref T src)
            => ref @as<T,byte>(src);

        /// <summary>
        /// Presents a T-reference as a byte reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <remarks>For all T, effects: mov rax,rdx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort @ref<T>(W16 w, ref T src)
            => ref @as<T,ushort>(src);

        /// <summary>
        /// Presents a T-reference as a byte reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <remarks>For all T, effects: mov rax,rdx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint @ref<T>(W32 w, ref T src)
            => ref @as<T,uint>(src);

        /// <summary>
        /// Presents a T-reference as a uint64 reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <remarks>For all T, effects: mov rax,rdx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong @ref<T>(W64 w, ref T src)
            => ref @as<T,ulong>(src);

        /// <summary>
        /// Creates a reference to a string
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe StringRef @ref(string src)
            => new StringRef((ulong)pchar(src), (uint)src.Length);

        /// <summary>
        /// Creates a reference to a string that includes 32 bits of arbitrary data
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe StringRef @ref(string src, uint user)
            => new StringRef((ulong)pchar(src), (uint)src.Length, user);

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
            => ref memory.@ref<T>(pSrc);

        /// <summary>
        /// Returns a reference to an identified location
        /// </summary>
        /// <param name="src">The source address</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ref T @ref<T>(MemoryAddress src)
            => ref memory.@ref<T>(src);

        /// <summary>
        /// Presents an S-pointer as a T-reference
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ref T @ref<S,T>(S* pSrc)
            where S : unmanaged
                => ref memory.@ref<S,T>(pSrc);
    }
}
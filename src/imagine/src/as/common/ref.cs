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
        /// <remarks>For all T, effects: mov rax,rcx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ref T @ref<T>(T* ptr)            
            where T : unmanaged
                => ref AsRef<T>(ptr);
                
        /// <summary>
        /// Presents a T-reference as a byte reference and effects mov rax,rdx for all T
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <remarks>For all T, effects: mov rax,rdx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte @ref<T>(W8 w, ref T src)
            => ref As<T,byte>(ref src);

        /// <summary>
        /// Presents a T-reference as a byte reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <remarks>For all T, effects: mov rax,rdx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort @ref<T>(W16 w, ref T src)
            => ref As<T,ushort>(ref src);

        /// <summary>
        /// Presents a T-reference as a byte reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <remarks>For all T, effects: mov rax,rdx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint @ref<T>(W32 w, ref T src)
            => ref As<T,uint>(ref src);

        /// <summary>
        /// Presents a T-reference as a uint64 reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The source type</typeparam>
        /// <remarks>For all T, effects: mov rax,rdx</remarks>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong @ref<T>(W64 w, ref T src)
            => ref As<T,ulong>(ref src);
    }
}
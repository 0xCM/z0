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
        /// <summary>
        /// Presents a string as a <see cref='Ref'/>
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe Ref<string> segref(string src)
            => new Ref<string>(vparts(N128.N, (ulong)pchar2(src), size(src)));

        /// <summary>
        /// Presents a reference as a .. reference
        /// </summary>
        /// <param name="src">The leading cell</param>
        /// <param name="count">The covered cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ref<T> segref<T>(in T src, uint count)
            => new Ref(address(src), count*size<T>());

        /// <summary>
        /// Captures a parametric reference to cell content beginning at a specified address
        /// </summary>
        /// <param name="src">The content address</param>
        /// <param name="count">The content cell count</param>
        /// <typeparam name="T">The content type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Ref<T> segref<T>(MemoryAddress src, uint count)
            => new Ref<T>(segref((void*)src, size<T>(count)));

        /// <summary>
        /// Captures an untyped sized reference
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        /// <param name="size">The data size</param>
        [MethodImpl(Inline), Op]
        public static unsafe Ref segref(void* pSrc, uint size)
            => new Ref((ulong)pSrc, size);

        /// <summary>
        /// Captures an untyped sized reference
        /// </summary>
        /// <param name="src">The reference address</param>
        /// <param name="size">The data size</param>
        [MethodImpl(Inline), Op]
        public static Ref segref(MemoryAddress src, uint size)
            => new Ref(src, size);
    }
}
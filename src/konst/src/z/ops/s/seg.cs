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
        /// Presents a reference as a .. reference
        /// </summary>
        /// <param name="src">The leading cell</param>
        /// <param name="count">The covered cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ref<T> seg<T>(in T src, uint count)
            => new Ref(address(src), count*size<T>());
    
        /// <summary>
        /// Captures a parametric reference to cell content beginning at a specified address
        /// </summary>
        /// <param name="src">The content address</param>
        /// <param name="count">The content cell count</param>
        /// <typeparam name="T">The content type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Ref<T> seg<T>(MemoryAddress src, uint count)
            => new Ref<T>(seg((void*)src, size<T>(count)));

        /// <summary>
        /// Captures an untyped sized reference
        /// </summary>
        /// <param name="pSrc">The source pointer</param>
        /// <param name="size">The data size</param>
        [MethodImpl(Inline)]
        public static unsafe Ref seg(void* pSrc, uint size)
            => new Ref((ulong)pSrc, size);

        /// <summary>
        /// Captures an untyped sized reference
        /// </summary>
        /// <param name="src">The reference address</param>
        /// <param name="size">The data size</param>
        [MethodImpl(Inline)]
        public static Ref seg(MemoryAddress src, uint size)
            => new Ref(src, size);
    }
}
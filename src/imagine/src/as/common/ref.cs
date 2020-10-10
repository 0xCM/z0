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

    partial struct AsDeprecated
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

    }
}
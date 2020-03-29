//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using static Components;

    partial class Core
    {
        /// <summary>
        /// Presents a readonly reference as a generic pointer which should intself be considered constant
        /// but, as far as the author is aware, no facility within the language can encode that constraint
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* constptr<T>(in T src)
            where T : unmanaged
                => ptr(ref edit(in src));

        /// <summary>
        /// Presents a readonly reference as a generic pointer displaced by an element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* constptr<T>(in T src, int offset)
            where T : unmanaged
                => ptr(ref edit(in skip(in src, offset)));
    }
}
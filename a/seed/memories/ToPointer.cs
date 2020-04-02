//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    partial class XTend
    {
        [MethodImpl(Inline)]
        public static unsafe T* ToPointer<T>(this IntPtr src)
            where T : unmanaged
                => (T*)src.ToPointer();

        /// <summary>
        /// Gets the void* for the identified field
        /// </summary>
        /// <param name="src">The runtime field handle</param>
        [MethodImpl(Inline)]
        public static unsafe void* ToPointer<T>(this RuntimeFieldHandle src)
            where T : unmanaged
                => src.Value.ToPointer<T>();

        /// <summary>
        /// Uses the (void*) explicit operator defined by the source type to
        /// present said source as a void*
        /// </summary>
        /// <param name="src">The source pointer representative</param>
        [MethodImpl(Inline)]
        public static unsafe void* ToVoid(this IntPtr src)
            => (void*)src;
    }
}
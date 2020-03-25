//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Root
    {                
        /// <summary>
        /// Computes the byte-size of a type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        public static int size<T>()
            => Unsafe.SizeOf<T>();

        /// <summary>
        /// Computes the byte-size of a type
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        [MethodImpl(Inline)]
        public static int size<T>(T t)
            => Unsafe.SizeOf<T>();
    }
}
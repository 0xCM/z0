//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static OpacityKind;
    using static Part;

    partial struct sys
    {
        /// <summary>
        /// Allocates storage for a specified number of T-cells
        /// </summary>
        /// <param name="count">The cell allocation count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Options), Opaque(Alloc), Closures(AllNumeric)]
        public static T[] alloc<T>(int count)
            => new T[count];


        [MethodImpl(Options), Opaque(Alloc), Closures(Closure)]
        public static T[] alloc<T>(ulong count)
            => new T[count];

        /// <summary>
        /// Allocates a specified number of bytes
        /// </summary>
        /// <param name="count">The number of bytes to allocate</param>
        [MethodImpl(Options),  Opaque(Alloc)]
        public static byte[] alloc(int count)
            => new byte[count];
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public static partial class Root
    {        
        [MethodImpl(Inline)]
        public static Factory<T> factory<T>()
            => default;

        /// <summary>
        /// Allocates a span
        /// </summary>
        /// <param name="length">The number cells to allocate</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static Span<T> alloc<T>(int length, T t = default)
            => Spans.alloc<T>(length);

        /// <summary>
        /// Consructs an array from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static T[] array<T>(params T[] src)
            => src;

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

        /// <summary>
        /// Computes the bit-width of a type
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The type</typeparam>    
        [MethodImpl(Inline)]
        public static int bitsize<T>()            
            where T : unmanaged
                => Unsafe.SizeOf<T>()*8;

        /// <summary>
        /// Computes the bit-width of a type
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The type</typeparam>    
        [MethodImpl(Inline)]
        public static int bitsize<T>(T t)
            => Unsafe.SizeOf<T>()*8;
    }
}
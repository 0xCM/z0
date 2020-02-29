//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0 
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Buffers;
    
    using static Root;

    public static class MemoryStore
    {
        /// <summary>
        /// Enumerates the content of a readonly memory segment
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> enumerate<T>(ReadOnlyMemory<T> src)
            =>  MemoryMarshal.ToEnumerable(src);

        /// <summary>
        ///  Constructs a memory segment from the content of the (hopefully finite) stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> memory<T>(IEnumerable<T> src)
            => src.ToArray();

        /// <summary>
        /// Constructs a memory segment of specified length from a stream (allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="length">The length of the index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> memory<T>(IEnumerable<T> src, int length)
            => memory(src.Take(length));

        /// <summary>
        /// Constructs a mutable memory segment from a readonly memory segment
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> memory<T>(ReadOnlyMemory<T> src)
            => MemoryMarshal.AsMemory(src);

        /// <summary>
        ///  Constructs a memory segment from a parameter array (non-allocating)
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> memory<T>(params T[] src)
            => src;

        /// <summary>
        /// Casts memory cells of one type to another
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> cast<S,T>(Memory<S> src)
            where S : unmanaged
            where T : unmanaged
        {
            if (typeof(S) == typeof(T)) 
                return (Memory<T>)(object)src;
            return new MemoryCast<S, T>(src).Memory;
        }

        /// <summary>
        /// Reverses the memory cells in-place
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> reverse<T>(Memory<T> src)
        {
            src.Span.Reverse();
            return src;
        }

        /// <summary>
        /// Projects a memory source to target via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> map<S,T>(Memory<S> src, Func<S, T> f)
        {
            var dst = new T[src.Length];
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src.Span[i]);
            return dst;
        }

        /// <summary>
        /// Returns the common length of the operands if they are the same; otherwise, raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The element type of the first operand</typeparam>
        /// <typeparam name="S">The element type of the second operand</typeparam>
        [MethodImpl(Inline)]   
        public static int length<T>(ReadOnlyMemory<T> lhs, ReadOnlyMemory<T> rhs,  [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => lhs.Length == rhs.Length ? lhs.Length 
                    : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Buffers;

using Z0;

partial class zfunc
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
        /// If the length of a source span is less than a specified length, a new span of the desired length
        /// is allocated and then filled with the source span content; otherwise, the source span is returned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="minlen">The desired minimum length</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> extend<T>(Memory<T> src, int minlen)
        {
            if(src.Length >= minlen)
                return src;
            else
            {
                var dst = new T[minlen];
                src.CopyTo(dst); 
                return dst;               
            }
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
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);
}

//https://stackoverflow.com/questions/54511330/how-can-i-cast-memoryt-to-another
sealed class MemoryCast<S, T> : MemoryManager<T>
    where S : unmanaged
    where T : unmanaged
{
    readonly Memory<S> source;

    [MethodImpl(zfunc.Inline)]
    public MemoryCast(Memory<S> source) 
        => this.source = source;

    public override Span<T> GetSpan()
        => MemoryMarshal.Cast<S, T>(source.Span);

    protected override void Dispose(bool disposing) {}

    public override MemoryHandle Pin(int elementIndex = 0)
        => throw new NotSupportedException();

    public override void Unpin()
        => throw new NotSupportedException();
}

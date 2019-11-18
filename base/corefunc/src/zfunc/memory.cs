//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;
using System.Diagnostics;

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


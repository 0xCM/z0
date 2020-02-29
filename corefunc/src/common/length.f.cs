//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using Z0;

using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

partial class zfunc
{
    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(IReadOnlyList<T> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null) 
        => lhs.Count == rhs.Length ? lhs.Count : throw errors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(Span<S> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan<S> lhs, Span<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(T[] lhs, T[] rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
        => lhs.Length == rhs.Length ? lhs.Length : throw errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);
}
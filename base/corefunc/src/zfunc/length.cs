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

using Z0;

partial class zfunc
{

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(Span<T> lhs, IReadOnlyList<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Count ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Count, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(IReadOnlyList<T> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Count == rhs.Length ? lhs.Count
                : throw Errors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(ReadOnlySpan<T> lhs, IReadOnlyList<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Count ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Count, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(IReadOnlyList<T> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Count == rhs.Length ? lhs.Count
                : throw Errors.LengthMismatch(lhs.Count, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(Span<S> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan<S> lhs, Span<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan<S> lhs, ReadOnlySpan<T> rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<T>(T[] lhs, T[] rhs, [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> rhs,  [CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where S : unmanaged
            where T : unmanaged
            => lhs.Length == rhs.Length ? lhs.Length 
                : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the length of spans of equal length; otherwise raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    [MethodImpl(Inline)]   
    public static int length<S,T>(Span256<S> lhs, Span256<T> rhs, [CallerMemberName] string caller = null,
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : unmanaged
            where S : unmanaged
                => lhs.Length == rhs.Length ? lhs.Length : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);

    /// <summary>
    /// Returns the common length of the operands if they are the same; otherwise, raises an error
    /// </summary>
    /// <param name="lhs">The left span</param>
    /// <param name="rhs">The right span</param>
    /// <typeparam name="T">The element type of the first operand</typeparam>
    /// <typeparam name="S">The element type of the second operand</typeparam>
    [MethodImpl(Inline)]   
    public static int length<S,T>(ReadOnlySpan256<S> lhs, ReadOnlySpan256<T> rhs,[CallerMemberName] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : unmanaged
            where S : unmanaged
                =>  lhs.Length == rhs.Length ? lhs.Length : throw Errors.LengthMismatch(lhs.Length, rhs.Length, caller, file, line);



}
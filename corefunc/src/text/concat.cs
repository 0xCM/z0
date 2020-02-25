//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Concatenates a sequence of strings
    /// </summary>
    /// <param name="src">The characters to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(IEnumerable<string> src)
        => text.concat(src);

    /// <summary>
    /// Concatenates a sequence of strings intersprsed by a character delimiter
    /// </summary>
    /// <param name="src">The characters to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(IEnumerable<string> src, char sep)
        => text.concat(src,sep);

    /// <summary>
    /// Concatenates a sequence of characters
    /// </summary>
    /// <param name="src">The characters to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(IEnumerable<char> src)
        => text.concat(src);

    /// <summary>
    /// Joins the string representation of a sequence of values
    /// </summary>
    /// <param name="src">The values to be joined</param>
    /// <param name="sep">The value delimiter</param>
    [MethodImpl(Inline)]
    public static string concat(IEnumerable<object> src, string sep)
        => text.concat(src,sep);

    /// <summary>
    /// Concatenates a character array
    /// </summary>
    /// <param name="src">The characters to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(params char[] src)
        => text.concat(src);

    /// <summary>
    /// Concatenates an array of strings
    /// </summary>
    /// <param name="src">The strings to concatenate</param>
    [MethodImpl(Inline)]
    public static string concat(params string[] src)
        => text.concat(src);
    
    /// <summary>
    /// Concatenates an arbitrary number of string representations
    /// </summary>
    /// <param name="src">The strings to be concatenated</param>
    [MethodImpl(Inline)]   
    public static string concat(params object[] src)    
        => text.concat(src);

    [MethodImpl(Inline)]   
    public static string concat(ReadOnlySpan<string> src, string sep)
        => text.concat(src,sep);

    [MethodImpl(Inline)]   
    public static string concat(Span<string> src, string sep)
        => text.concat(src,sep);
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Creates a span of replicated characters 
    /// </summary>
    /// <param name="src"></param>
    /// <param name="count"></param>
    [MethodImpl(Inline)]
    public static ReadOnlySpan<char> Replicate(this char src, int count)
        => new string(src,count);

    [MethodImpl(Inline)]
    public static ReadOnlySpan<char> Replicate(this char src, uint count)
        => new string(src,(int)count);

    public static string Format(this Utf8AsciPoint src)
    {
        var bits = src.Code.FormatBits();
        var num = src.Code.FormatHex();
        var str = src.IsControl ? "___"  : $"'{src.ToChar()}'";
        return $"{num} {bits} {str}";
    }
}
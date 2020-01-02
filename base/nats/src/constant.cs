//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

internal static class constant
{
    public const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static byte[] digits(ulong src)
    {
        var text = src.ToString();
        var chars = new byte[text.Length];
        for(var i=0; i<text.Length; i++)
            chars[i] = byte.Parse(text[i].ToString());                
        return chars;
        //=> src.ToString().Select(c => byte.Parse(c.ToString())).ToArray();   
    }


}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Collections.Generic;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Explicitly casts a source value to value of the indicated type, raising an exception if operation fails
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T cast<T>(object src) 
        => (T) src;

    [MethodImpl(Inline)]   
    public static T[] array<T>(params T[] src)
        => src;

    [MethodImpl(NotInline)]   
    public static T[] array<T>(int length)
        => new T[length];

    [MethodImpl(NotInline)]   
    public static T[] array<T>(long length)
        => new T[length];

    [MethodImpl(NotInline)]   
    public static T[] array<T>(IEnumerable<T> src)
        => src.ToArray();

    /// <summary>
    /// Allocates an array and fills it wih a specified value
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(NotInline)]
    public static T[] array<T>(long len, T fill)
    {        
        var dst = array<T>(len);
        dst.Fill(fill);
        return dst;
    }

}
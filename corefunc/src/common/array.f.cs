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

    /// <summary>
    /// Constructs an array filled with a replicated value
    /// </summary>
    /// <param name="value">The value to replicate</param>
    /// <param name="count">The number of replicants</param>
    /// <typeparam name="T">The replicant type</typeparam>
    public static T[] repeat<T>(T value, ulong count)
    {
        var dst = array<T>((int)count);
        for(var idx = 0U; idx < count; idx ++)
            dst[idx] = value;
        return dst;            
    }

    /// <summary>
    /// Reverses an array in-place
    /// </summary>
    /// <param name="src">The source array</param>
    /// <typeparam name="T">The element type</typeparam>
    public static T[] reverse<T>(T[] src)
    {
        Array.Reverse(src);
        return src;        
    }

    [MethodImpl(Inline)]   
    public static T[] repeat<T>(T value, int count)
        => repeat(value, (ulong)count);

    [MethodImpl(Inline)]   
    public static T[] repeat<T>(T value, uint count)
        => repeat(value, (ulong)count);

    [MethodImpl(Inline)]   
    public static void copy<T>(T[] src, T[] dst)
        => Array.Copy(src,dst,length(src,dst));
    
}
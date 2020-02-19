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
    [MethodImpl(Inline)]   
    public static T[] array<T>(params T[] src)
        => src;

    [MethodImpl(Inline)]   
    public static T[] array<T>(int length)
        => new T[length];

    [MethodImpl(Inline)]   
    public static T[] array<T>(IEnumerable<T> src)
        => src.ToArray();

    /// <summary>
    /// Allocates an array
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(NotInline)]
    public static T[] alloc<T>(long len)
        => new T[len];


    /// <summary>
    /// Allocates an array and fills it wih a specified value
    /// </summary>
    /// <param name="len">The length of the array</param>
    /// <typeparam name="T">The array element type</typeparam>
    [MethodImpl(NotInline)]
    public static T[] alloc<T>(long len, T fill)
    {
        var dst = alloc<T>((int)len);
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
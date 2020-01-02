//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Reduces a stream to a single value via an additive monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T foldA<T>(IEnumerable<T> src)
        where T : unmanaged, IMonoidA<T>
    {        
        var cumulant = default(T).Zero;
        var items = src.ToArray();
        var count = items.Length;
        for(var i=0; i<count; i++)
            cumulant = cumulant.Add(items[i]);            
        return cumulant;
    }
                
    /// <summary>
    /// Reduces a stream to a single value via a multiplicative monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T foldM<T>(IEnumerable<T> src)
        where T : unmanaged, IMonoidM<T>
    {        
        var cumulant = default(T).One;
        foreach(var item in src)
            cumulant = cumulant.Mul(item);            
        return cumulant;
    }
                
    /// <summary>
    /// Reduces a stream to a single value via a specified monoid
    /// </summary>
    /// <param name="src">The source stream</param>
    /// <typeparam name="T">The stream element type</typeparam>
    [MethodImpl(Inline)]
    public static T fold<T>(IEnumerable<T> src, IMonoidalOps<T> monoid)
        where T : unmanaged
    {
        
        var cumulant = monoid.Identity;
        foreach(var item in src)
            cumulant = monoid.Compose(cumulant, item);            
        return cumulant;
    }
}
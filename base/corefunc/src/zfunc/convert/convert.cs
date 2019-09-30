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

using Z0;

partial class zfunc
{

    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src, out T dst)
        where T : unmanaged
        where S : unmanaged
            => dst = Converter.convert<S,T>(src);
           
    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src)
        where T : unmanaged
        where S : unmanaged
           => Converter.convert<S,T>(src);

    /// <summary>
    /// Converts a blocked span of one value type to a blocked span of another value type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static Span256<T> convert<S,T>(Span256<S> src)
        where T : unmanaged
        where S : unmanaged
    {
        var dst = Span256.Alloc<T>(src.Length);
        for(var i=0; i< src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }

    /// <summary>
    /// Converts a span of one value type to a span of another value type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> convert<S,T>(Span<S> src)
        where T : unmanaged
        where S : unmanaged
    {
        Span<T> dst = new T[src.Length];
        for(var i=0; i< src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }

    /// <summary>
    /// Converts a span of one value type to a span of another value type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T[] convert<S,T>(S[] src)
        where T : unmanaged
        where S : unmanaged
    {
        var dst = new T[src.Length];
        for(var i=0; i< src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }

    /// <summary>
    /// Converts a natural span of one value type to a natural span of another value type
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static Span<T> convert<N,S,T>(Span<N,S> src)
        where N : ITypeNat, new()
        where T : unmanaged
        where S : unmanaged
    {
        Span<T> dst = new T[src.Length];
        for(var i=0; i< src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }

    [MethodImpl(Inline)]   
    public static Span<T> convert<S,T>(ReadOnlySpan<S> src)
        where T : unmanaged
        where S : unmanaged
    {
        var dst = span<T>(src.Length);
        for(var i=0; i<src.Length; i++)
            dst[i] = convert<S,T>(src[i]);
        return dst;
    }

    [MethodImpl(Inline)]   
    public static T convert<T>(sbyte src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(byte src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(short src)
        where T : unmanaged
            => Converter.convert<T>(src);
    
    [MethodImpl(Inline)]   
    public static T convert<T>(ushort src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(int src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(uint src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(long src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(ulong src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(float src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(double src)
        where T : unmanaged
            => Converter.convert<T>(src);

    [MethodImpl(Inline)]   
    public static T convert<T>(char src)
        where T : unmanaged
            => Converter.convert<T>(src);


}
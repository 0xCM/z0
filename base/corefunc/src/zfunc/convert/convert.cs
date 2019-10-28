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
using static Z0.As;
partial class zfunc
{

    /// <summary>
    /// If possible, applies the conversion S -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src, out T dst)
        where T : unmanaged
        where S : unmanaged
            => dst = Converter.convert<S,T>(src);
           
    /// <summary>
    /// If possible, applies the conversion S -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<S,T>(S src)
        where T : unmanaged
        where S : unmanaged
           => Converter.convert<S,T>(src);

    /// <summary>
    /// If possible, applies the conversion S -> T for each element of a source span
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
    /// If possible, applies the conversion S -> T for each element of a source span
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
    /// If possible, applies the conversion S -> T for each element of an array
    /// </summary>
    /// <param name="src">The source array</param>
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
    /// If possible, applies the conversion S -> T for each element of a source span
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

    /// <summary>
    /// If possible, applies the conversion S -> T for each element of a source span
    /// </summary>
    /// <param name="src">The source span</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
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

    /// <summary>
    /// Converts a bit to an unsigned integral type with the value 0 or 1 as determined by the state of thebit 
    /// </summary>
    /// <param name="src">The source bit</param>
    /// <typeparam name="T">The target primal type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(bit src)
        where T : unmanaged
    {
        if(typeof(T) == typeof(byte))
            return generic<T>(src.AsUInt8());
        else if(typeof(T) == typeof(ushort))
            return generic<T>(src.AsUInt16());
        else if(typeof(T) == typeof(uint))
            return generic<T>(src.AsUInt32());
        else if(typeof(T) == typeof(ulong))
            return generic<T>(src.AsUInt64());
        else
            throw unsupported<T>();
    }

    
    /// <summary>
    /// If possible, applies the conversion sbyte -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(sbyte src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion byte -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(byte src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion short -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(short src)
        where T : unmanaged
            => Converter.convert<T>(src);
    
    /// <summary>
    /// If possible, applies the conversion ushort -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(ushort src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion int -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(int src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion uint -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(uint src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion long -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(long src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion ulong -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(ulong src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion float -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(float src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion double -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(double src)
        where T : unmanaged
            => Converter.convert<T>(src);

    /// <summary>
    /// If possible, applies the conversion char -> T
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The target type</typeparam>
    [MethodImpl(Inline)]   
    public static T convert<T>(char src)
        where T : unmanaged
            => Converter.convert<T>(src);
}
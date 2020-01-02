//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.As;

partial class zfunc
{
    /// <summary>
    /// Returns true if the primal source type is signed, false otherwise
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static bool signed<T>()
        where T : unmanaged
        => typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long)
        || typeof(T) == typeof(float) 
        || typeof(T) == typeof(double);


    /// <summary>
    /// Returns true if the specified type is an unsigned primal integral type
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool unsigned<T>()
        where T : unmanaged
        => typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong);

    /// <summary>
    /// Returns true if the specified type is a signed primal integral type
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool signedint<T>()
        where T : unmanaged
        => typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long);

    /// <summary>
    /// Returns true if the specified type is a primal integer
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool integral<T>()
        where T : unmanaged
        => typeof(T) == typeof(byte) 
        || typeof(T) == typeof(ushort) 
        || typeof(T) == typeof(uint) 
        || typeof(T) == typeof(ulong)
        || typeof(T) == typeof(sbyte) 
        || typeof(T) == typeof(short) 
        || typeof(T) == typeof(int) 
        || typeof(T) == typeof(long);

    /// <summary>
    /// Returns true if the spedified type is a 32-bit or 64-bit floating point
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool floating<T>()
        where T : unmanaged
            => typeof(T) == typeof(float) 
            || typeof(T) == typeof(double);

    /// <summary>
    /// Returns the types numeric suffix character, if any; either i, u or f
    /// which respectively denote signed integers, unsigned integers and floating-point
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static char suffix<T>(bool general = true)
        where T : unmanaged
            =>  floating<T>() ? AsciLower.f  
              : signedint<T>() ? AsciLower.i  
              : unsigned<T>() ?  AsciLower.u 
              : AsciSym.Question;

    /// <summary>
    /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
    /// </summary>
    /// <param name="x0">The lower bound</param>
    /// <param name="x1">The upper bound</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> range<T>(T x0, T x1)
        where T : unmanaged
            => range_1(x0,x1,null);


    /// <summary>
    /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
    /// </summary>
    /// <param name="x0">The lower bound</param>
    /// <param name="x1">The upper bound</param>
    /// <param name="step">The step size</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> range<T>(T x0, T x1, T step)
        where T : unmanaged
            => range_1(x0,x1,step);


    /// <summary>
    /// Defines a generic complex number
    /// </summary>
    /// <param name="re">The real part</param>
    /// <param name="im">The imaginary part</param>
    /// <typeparam name="T">The underlying primal type</typeparam>
    [MethodImpl(Inline)]
    public static Complex<T> complex<T>(T re, T im = default)
        where T : unmanaged, IEquatable<T>
            => ComplexNumber.Define(re,im);

    /// <summary>
    /// Defines a scalar sequence {0,1,...,count-1}
    /// </summary>
    /// <param name="count">The number of elements in the sequence</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> range<T>(T count)
        where T : unmanaged
            => range(default(T), count);

    /// <summary>
    /// Defines a scalar sequence [first, ..., (first + N)]
    /// </summary>
    /// <param name="first"></param>
    /// <typeparam name="N"></typeparam>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> range<N,T>(T first, N n = default)
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        var last = convert<T>(n.NatValue);
        return range(first,last);
    }

    [MethodImpl(Inline)]
    static IEnumerable<T> range_1<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
            return range8i(x0,x1,step);
        else if(typeof(T) == typeof(byte))
            return range8u(x0,x1,step);
        else if(typeof(T) == typeof(short))
            return range16i(x0,x1,step);
        else if(typeof(T) == typeof(ushort))
            return range16u(x0,x1,step);
        else
            return range_2(x0,x1,step);

    }

    [MethodImpl(Inline)]
    static IEnumerable<T> range_2<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        if(typeof(T) == typeof(int))
            return range32i(x0,x1,step);
        else if(typeof(T) == typeof(uint))
            return range32u(x0,x1,step);
        else if(typeof(T) == typeof(long))
            return range64i(x0,x1,step);
        else if(typeof(T) == typeof(ulong))
            return range64u(x0,x1,step);
        else
            return range_3(x0,x1,step);

    }

    [MethodImpl(Inline)]
    static IEnumerable<T> range_3<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        if(typeof(T) == typeof(float))
            return range32f(x0,x1,step);
        else if(typeof(T) == typeof(double))
            return range64f(x0,x1,step);
        else
            throw unsupported<T>();
    }

    /// <summary>
    /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
    /// </summary>
    /// <param name="x0">The lower bound</param>
    /// <param name="x1">The upper bound</param>
    /// <param name="step">The step size</param>
    /// <typeparam name="T">The primal type</typeparam>
    static IEnumerable<T> range_old<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
        {
            var min = Unsafe.As<T,sbyte>(ref x0);
            var max = Unsafe.As<T,sbyte>(ref x1);
            var _step = Unsafe.As<T?, sbyte?>(ref step) ??(sbyte)1;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<sbyte,T>(ref i);
        }
        else if(typeof(T) == typeof(byte))
        {
            var min = Unsafe.As<T,byte>(ref x0);
            var max = Unsafe.As<T,byte>(ref x1);
            var _step = Unsafe.As<T?, byte?>(ref step) ??(byte)1;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<byte,T>(ref i);
        }
        else if(typeof(T) == typeof(short))
        {
            var min = Unsafe.As<T,short>(ref x0);
            var max = Unsafe.As<T,short>(ref x1);
            var _step = Unsafe.As<T?, short?>(ref step) ?? (short)1;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<short,T>(ref i);
        }
        else if(typeof(T) == typeof(ushort))
        {
            var min = Unsafe.As<T,ushort>(ref x0);
            var max = Unsafe.As<T,ushort>(ref x1);
            var _step = Unsafe.As<T?, ushort?>(ref step) ?? (ushort)1;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<ushort,T>(ref i);
        }
        else if(typeof(T) == typeof(int))
        {
            var min = Unsafe.As<T,int>(ref x0);
            var max = Unsafe.As<T,int>(ref x1);
            var _step = Unsafe.As<T?, int?>(ref step) ?? 1;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<int,T>(ref i);
        }
        else if(typeof(T) == typeof(uint))
        {
            var min = Unsafe.As<T,uint>(ref x0);
            var max = Unsafe.As<T,uint>(ref x1);
            var _step = Unsafe.As<T?, uint?>(ref step) ?? 1u;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<uint,T>(ref i);
        }
        else if(typeof(T) == typeof(long))
        {
            var min = Unsafe.As<T,long>(ref x0);
            var max = Unsafe.As<T,long>(ref x1);
            var _step = Unsafe.As<T?, long?>(ref step) ?? 1L;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<long,T>(ref i);
        }
        else if(typeof(T) == typeof(ulong))
        {
            var min = Unsafe.As<T,ulong>(ref x0);
            var max = Unsafe.As<T,ulong>(ref x1);
            var _step = Unsafe.As<T?, ulong?>(ref step) ?? 1ul;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<ulong,T>(ref i);
        }
        else if(typeof(T) == typeof(float))
        {
            var min = Unsafe.As<T,float>(ref x0);
            var max = Unsafe.As<T,float>(ref x1);
            var _step = Unsafe.As<T?, float?>(ref step) ?? 1f;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<float,T>(ref i);
        }
        else if(typeof(T) == typeof(double))
        {
            var min = Unsafe.As<T,double>(ref x0);
            var max = Unsafe.As<T,double>(ref x1);
            var _step = Unsafe.As<T?, double?>(ref step) ?? 1d;
            for(var i = min; i <= max; i += _step)            
                yield return Unsafe.As<double,T>(ref i);
        }
        else
            throw unsupported<T>();
    }

    static IEnumerable<T> range8i<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,sbyte>(ref x0);
        var max = Unsafe.As<T,sbyte>(ref x1);
        var _step = Unsafe.As<T?, sbyte?>(ref step) ??(sbyte)1;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<sbyte,T>(ref i);
    }

    static IEnumerable<T> range8u<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,byte>(ref x0);
        var max = Unsafe.As<T,byte>(ref x1);
        var _step = Unsafe.As<T?, byte?>(ref step) ??(byte)1;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<byte,T>(ref i);
    }
    
    static IEnumerable<T> range16i<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,short>(ref x0);
        var max = Unsafe.As<T,short>(ref x1);
        var _step = Unsafe.As<T?, short?>(ref step) ?? (short)1;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<short,T>(ref i);
    }

    static IEnumerable<T> range16u<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,ushort>(ref x0);
        var max = Unsafe.As<T,ushort>(ref x1);
        var _step = Unsafe.As<T?, ushort?>(ref step) ?? (ushort)1;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<ushort,T>(ref i);
    }

    static IEnumerable<T> range32i<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,int>(ref x0);
        var max = Unsafe.As<T,int>(ref x1);
        var _step = Unsafe.As<T?, int?>(ref step) ?? 1;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<int,T>(ref i);
    }

    static IEnumerable<T> range32u<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,uint>(ref x0);
        var max = Unsafe.As<T,uint>(ref x1);
        var _step = Unsafe.As<T?, uint?>(ref step) ?? 1u;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<uint,T>(ref i);
    }

    static IEnumerable<T> range64i<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,long>(ref x0);
        var max = Unsafe.As<T,long>(ref x1);
        var _step = Unsafe.As<T?, long?>(ref step) ?? 1L;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<long,T>(ref i);
    }

    static IEnumerable<T> range64u<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,ulong>(ref x0);
        var max = Unsafe.As<T,ulong>(ref x1);
        var _step = Unsafe.As<T?, ulong?>(ref step) ?? 1ul;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<ulong,T>(ref i);
    }

    static IEnumerable<T> range32f<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,float>(ref x0);
        var max = Unsafe.As<T,float>(ref x1);
        var _step = Unsafe.As<T?, float?>(ref step) ?? 1f;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<float,T>(ref i);
    }

    static IEnumerable<T> range64f<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        var min = Unsafe.As<T,double>(ref x0);
        var max = Unsafe.As<T,double>(ref x1);
        var _step = Unsafe.As<T?, double?>(ref step) ?? 1d;
        for(var i = min; i <= max; i += _step)            
            yield return Unsafe.As<double,T>(ref i);
    }

}
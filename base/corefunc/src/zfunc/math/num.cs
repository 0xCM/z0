//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    /// Returns generic 0 for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T zero<T>()
        where T : unmanaged
            => ref GConst.zero<T>();

    /// <summary>
    /// Returns generic 1 for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T one<T>()
        where T : unmanaged
            => ref GConst.one<T>();

    /// <summary>
    /// Returns the minimum value for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T minval<T>()
        where T : unmanaged
            => ref GConst.minval<T>();

    /// <summary>
    /// Returns the minimum value for a primal source type
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static ref readonly T maxval<T>()
        where T : unmanaged
            => ref GConst.maxval<T>();

    /// <summary>
    /// Returns true if the primal source type is signed, false otherwise
    /// </summary>
    /// <typeparam name="T">The primal source type</typeparam>
    [MethodImpl(Inline)]
    public static bool signed<T>()
        where T : unmanaged
            => PrimalInfo.signed<T>();

    /// <summary>
    /// Returns true if the specified type is an unsigned primal integral type
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool unsignedint<T>()
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
            => signedint<T>() || unsignedint<T>();

    /// <summary>
    /// Returns true if the spedified type is a 32-bit or 64-bit floating point
    /// </summary>
    /// <typeparam name="T">The type to evaluate</typeparam>
    [MethodImpl(Inline)]
    public static bool floating<T>()
        where T : unmanaged
            => typeof(T) == typeof(float) || typeof(T) == typeof(double);

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
              : unsignedint<T>() ?  AsciLower.u 
              : AsciSym.Question;

    /// <summary>
    /// Creates an enumerable sequence that ranges between inclusive upper and lower bounds
    /// </summary>
    /// <param name="x0">The lower bound</param>
    /// <param name="x1">The upper bound</param>
    /// <param name="step">The step size</param>
    /// <typeparam name="T">The primal type</typeparam>
    public static IEnumerable<T> range<T>(T x0, T x1, T? step = null)
        where T : unmanaged
    {
        if(typeof(T) == typeof(sbyte))
        {
            var min = int8(x0);
            var max = int8(x1);
            var _step = int8(step) ??(sbyte)1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(byte))
        {
            var min = uint8(x0);
            var max = uint8(x1);
            var _step = uint8(step) ??(byte)1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(short))
        {
            var min = int16(x0);
            var max = int16(x1);
            var _step = int16(step) ?? (short)1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(ushort))
        {
            var min = uint16(x0);
            var max = uint16(x1);
            var _step = uint16(step) ?? (ushort)1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(int))
        {
            var min = int32(x0);
            var max = int32(x1);
            var _step = int32(step) ?? 1;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(uint))
        {
            var min = uint32(x0);
            var max = uint32(x1);
            var _step = uint32(step) ?? 1u;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(long))
        {
            var min = int64(x0);
            var max = int64(x1);
            var _step = int64(step) ?? 1L;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(ulong))
        {
            var min = uint64(x0);
            var max = uint64(x1);
            var _step = uint64(step) ?? 1ul;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(float))
        {
            var min = float32(x0);
            var max = float32(x1);
            var _step = float32(step) ?? 1f;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else if(typeof(T) == typeof(double))
        {
            var min = float64(x0);
            var max = float64(x1);
            var _step = float64(step) ?? 1d;
            for(var i = min; i <= max; i += _step)            
                yield return generic<T>(i);
        }
        else
            throw unsupported<T>();
    }

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
    /// <typeparam name="T"></typeparam>
    [MethodImpl(Inline)]
    public static IEnumerable<T> range<N,T>(T first, N n = default)
        where T : unmanaged
        where N : ITypeNat, new()
    {
        var last = convert<T>(n.value);
        return range(first,last);
    }


}
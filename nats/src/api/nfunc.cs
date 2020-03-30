//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

using Z0;
using static Z0.Components;

public static class nfunc
{
    [MethodImpl(Inline)]   
    public static NatVal natval<N>()
        where N : unmanaged, ITypeNat
            => NatVal.From(TypeNats.value<N>());

    /// <summary>
    /// Converts an integer to a sequence of digits
    /// </summary>
    /// <param name="src">The source value</param>
    internal static byte[] digits(ulong src)
        => TypeNats.digits(src);

    [MethodImpl(Inline)]   
    internal static T[] repeat<T>(T value, ulong count)
    {
        var dst = new T[count];
        for(var idx = 0U; idx < count; idx ++)
            dst[idx] = value;
        return dst;            
    }

    static IEnumerable<ulong> range(ulong first, ulong last)
    {
        var current = first;
        if(first < last)
            while(current<= last)
                yield return current++;
        else
            while(current >= last)
                yield return current--;
    }

    /// <summary>
    /// Computes the integral divisors of a number, exluding 1 and the number itself
    /// </summary>
    /// <param name="src">The source value</param>
    static IEnumerable<ulong> divisors(ulong src)
    {        
        if(src != 0 && src != 1)
        {
            var upper = src/2 + 1;
            var candidates = range(2ul, upper);
            foreach(var c in candidates)
                if(src % c == 0 )
                    yield return c;
        }    
    }

    /// <summary>
    /// Determines whether an integer is prime
    /// </summary>
    /// <param name="x">The integer to examine</param>
    /// <typeparam name="T">The underlying integer type</typeparam>
    [MethodImpl(Inline)]   
    public static bool prime(ulong x)
    {
        var upperBound = Math.Ceiling(Math.Sqrt(x));
        return divisors(x).Count() == 0;
    }                

    /// <summary>
    /// Retrieves the value of the natural number associated with a typenat
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static ulong natu<N>() 
        where N : unmanaged, ITypeNat
            => TypeNats.value<N>();

    /// <summary>
    /// Retrieves the value of a type natural represented as a signed integer
    /// </summary>
    /// <typeparam name="N">The nat type</typeparam>
    [MethodImpl(Inline)]   
    public static int nati<N>() 
        where N : unmanaged, ITypeNat
            => (int)TypeNats.value<N>();

    /// <summary>
    /// Constructs a natural representative
    /// </summary>
    /// <typeparam name="K">The representative type</typeparam>
    [MethodImpl(Inline)]   
    public static K natrep<K>()
        where K : unmanaged, ITypeNat
            => new K(); 

    /// <summary>
    /// Constructs a 1-component natural dimension
    /// </summary>
    /// <typeparam name="K">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K> dim<K>()
        where K : unmanaged, ITypeNat
            => Dim.define<K>();

    /// <summary>
    /// Constructs a 1-component natural dimension
    /// </summary>
    /// <typeparam name="K">The natural type</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K> dim<K>(K k)
        where K : unmanaged, ITypeNat
            => Dim.define<K>();

    /// <summary>
    /// Constructs a 2-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2> dim<K1,K2>()
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
            => Dim.define<K1,K2>();

    /// <summary>
    /// Constructs a 2-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2> dim<K1,K2>(K1 k1, K2 k2)
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
            => Dim.define<K1,K2>();

    /// <summary>
    /// Constructs a 3-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    /// <typeparam name="K3">The type of the third component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2,K3> dim<K1,K2,K3>()
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
        where K3 : unmanaged, ITypeNat
            => Dim.define<K1,K2,K3>();

    /// <summary>
    /// Constructs a 3-component natural dimension
    /// </summary>
    /// <typeparam name="K1">The type of the first component</typeparam>
    /// <typeparam name="K2">The type of the second component</typeparam>
    /// <typeparam name="K3">The type of the third component</typeparam>
    [MethodImpl(Inline)]   
    public static Dim<K1,K2,K3> dim<K1,K2,K3>(K1 k1, K2 k2, K3 k3)
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
        where K3 : unmanaged, ITypeNat
            => Dim.define<K1,K2,K3>();

    /// <summary>
    /// Demands truth that is enforced with an exeption upon false
    /// </summary>
    /// <param name="x">The value to test</param>
    [MethodImpl(Inline)]   
    public static bool demand(bool x, string message = null)
        => x ? x : throw new Exception(message ?? "demand failed");

    [MethodImpl(Inline)]   
    public static Product<K1, K2> mul<K1,K2>(K1 k1 = default, K2 k2 = default)
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
            => Product<K1,K2>.Rep;

    [MethodImpl(Inline)]   
    public static int muli<K1,K2>(K1 k1 = default, K2 k2 = default)
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
            => (int)mul(k1,k2).NatValue;

    [MethodImpl(Inline)]   
    public static NatSum<K1, K2> sum<K1,K2>(K1 k1 = default, K2 k2 = default)
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
            => NatSum<K1,K2>.Rep;

    [MethodImpl(Inline)]
    public static void require<N>(int value)
        where N : unmanaged, ITypeNat
            => demand(nati<N>() == value, $"The source value {value} does not match the required natural {new N()}");
}
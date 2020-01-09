//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Reflection;

using Z0;

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
    /// Gets the assembly in which a parametric type is defined
    /// </summary>
    /// <typeparam name="T">The type to be examined</typeparam>
    [MethodImpl(Inline)]
    public static Assembly assembly<T>(T t = default)
        => typeof(T).Assembly;

    /// <summary>
    /// Returns 1 if the two parameteric types are the same, 0 otherwise
    /// </summary>
    /// <typeparam name="S">The first type</typeparam>
    /// <typeparam name="T">The second type</typeparam>
    [MethodImpl(Inline)]
    public static bit typematch<S,T>(S s = default, T t = default)
        => typeof(S) == typeof(T);

    /// <summary>
    /// Specifies the generic type definition for a specified generic type
    /// </summary>
    [MethodImpl(Inline)]   
    public static Type typedef(Type t)
        => t.GetGenericTypeDefinition();

    /// <summary>
    /// Returns the display name of the supplied type
    /// </summary>
    /// <param name="full">Whether the full name should be returned</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]   
    public static string typename<T>(T t = default)
        => typeof(T).DisplayName();

    /// <summary>
    /// Returns the display name of the source type
    /// </summary>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]   
    public static string label<T>(T t = default)
        => typeof(T).DisplayName();
    
    /// <summary>
    /// Produces a canonical designator of the form {bitsize[T]}{u | i | f} for a primal type
    /// </summary>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static string suffix<T>(T t = default)
        => Moniker.suffix(typeof(T).Kind());

    /// <summary>
    /// Produces a canonical designator of the form {bitsize(k)}{u | i | f} for a primal kind k
    /// </summary>
    /// <param name="k">The primal kind</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static string suffix(PrimalKind k)
        => Moniker.suffix(k);

    /// <summary>
    /// Defines a moniker with rendering {op}_{bitsize[T]}{u | i | f} that identifies an
    /// operation over a primal type of kind k and bit width N := bitsize(k)
    /// </summary>
    /// <param name="name">The base operator name</param>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker(string name, PrimalKind k)
        => Moniker.define(name,k);

    /// <summary>
    /// Derives a moniker from method metadata
    /// </summary>
    /// <param name="m">The source method</param>
    [MethodImpl(Inline)]   
    public static Moniker moniker(MethodInfo m)
        => Moniker.define(m);

    /// <summary>
    /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
    /// operation over a primal type of bit width N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, T t = default)
        => Moniker.define(opname,typeof(T).Kind());

    /// <summary>
    /// Defines a moniker with rendering {opname}_WxN{u | i | f} that identifies 
    /// an operation over intrinsic vectors or other segmented type of bit-width W
    /// defined over segments of kind k and bit-width N := bitsize(k)
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<W>(string opname, PrimalKind k, W w)
        where W : unmanaged, ITypeNat
            => Moniker.define(opname, k, w);

    /// <summary>
    /// Defines a moniker with rendering {opname}_WxN{u | i | f} that identifies 
    /// an operation over intrinsic vectors or other segmented types of bit-width W
    /// with segments of bit-width N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<W,T>(string opname, W w = default, T t = default)
        where W : unmanaged, ITypeNat
        where T : unmanaged
            => Moniker.define(opname,Classified.primalkind<T>(),w);

    /// <summary>
    /// Returns the System.Type of the supplied parametric type
    /// </summary>
    /// <param name="t">A representative value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static Type type<T>(T t = default) 
        => typeof(T);

    /// <summary>
    /// Returns the primal kind (possibly none) of a parametric type
    /// </summary>
    /// <param name="t">A representative value</param>
    /// <typeparam name="T">The source type</typeparam>
    [MethodImpl(Inline)]
    public static PrimalKind kind<T>(T t = default)
        where T : unmanaged
            => Classified.primalkind(t);
}
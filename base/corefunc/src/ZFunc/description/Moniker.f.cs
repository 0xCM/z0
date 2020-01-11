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
            => Moniker.define(opname,PrimalType.kind<T>(),w);
}
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
    /// Produces an identifier of the form {bitsize[T]}{u | i | f} for a primal type
    /// </summary>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static string primalsig<T>(T t = default)
        => PrimalType.signature(t);

    /// <summary>
    /// Produces an identifier of the form {bitsize(k)}{u | i | f} for a primal kind k
    /// </summary>
    /// <param name="k">The primal kind</param>
    [MethodImpl(Inline)]   
    public static string primalsig(PrimalKind k)
        => PrimalType.signature(k);

    /// <summary>
    /// Defines a moniker predicated on supplied text
    /// </summary>
    /// <param name="text">The source text</param>
    [MethodImpl(Inline)]   
    public static Moniker moniker(string text)
        => Moniker.Parse(text);

    /// <summary>
    /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
    /// operation over a primal type of bit width N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, T t = default)
        => OpIdentity.define(opname,typeof(T).Kind());

    /// <summary>
    /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
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
            => OpIdentity.segmented(opname,PrimalType.kind<T>(),w);

    /// <summary>
    /// Defines an identifier of the form {opname}_128xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, N128 w, T t = default)
        where T : unmanaged
            => OpIdentity.segmented(opname,PrimalType.kind<T>(),w);

    /// <summary>
    /// Defines an identifier of the form {opname}_128xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, HK.Vec128<T> hk)
        where T : unmanaged
            => OpIdentity.segmented(opname,PrimalType.kind<T>(), n128);

    /// <summary>
    /// Defines an identifier of the form {opname}_128xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, HK.Vec128 hk, T t = default)
        where T : unmanaged
            => OpIdentity.segmented(opname,PrimalType.kind<T>(), n128);

    /// <summary>
    /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, N256 w, T t = default)
        where T : unmanaged
            => OpIdentity.segmented(opname,PrimalType.kind<T>(),w);

    /// <summary>
    /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, HK.Vec256<T> hk)
        where T : unmanaged
            => OpIdentity.segmented(opname,PrimalType.kind<T>(),n256);

    /// <summary>
    /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static Moniker moniker<T>(string opname, HK.Vec256 hk, T t = default)
        where T : unmanaged
            => OpIdentity.segmented(opname,PrimalType.kind<T>(),n256);
}
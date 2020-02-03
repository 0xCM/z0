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
    public static TypeIdentity numericid<T>(T t = default)
        where T : unmanaged
            => TypeIdentities.numericid(t); 

    /// <summary>
    /// Defines a moniker with rendering {opname}_N{u | i | f} that identifies an
    /// operation over a primal type of bit width N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="t">A primal type representative</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]   
    public static OpIdentity identify<T>(string opname, T t = default)
        => OpIdentities.identify<T>(opname);

    /// <summary>
    /// Defines an identifier of the form {opname}_WxN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static OpIdentity identify<W,T>(string opname, W w = default, T t = default)
        where W : unmanaged, ITypeNat
        where T : unmanaged
            => OpIdentities.identify(opname,w, NumericType.kind<T>());

    /// <summary>
    /// Defines an identifier of the form {opname}_128xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static OpIdentity identify<T>(string opname, N128 w, T t = default)
        where T : unmanaged
            => OpIdentities.identify(opname,w, NumericType.kind<T>());

    /// <summary>
    /// Defines an identifier of the form {opname}_128xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static OpIdentity identify<T>(string opname, HK.Vec128<T> hk)
        where T : unmanaged
            => OpIdentities.identify(opname, n128, NumericType.kind<T>());

    /// <summary>
    /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static OpIdentity identify<T>(string opname, N256 w, T t = default)
        where T : unmanaged
            => OpIdentities.identify(opname,w, NumericType.kind<T>());

    /// <summary>
    /// Defines an identifier of the form {opname}_256xN{u | i | f} where N := bitsize[T]
    /// </summary>
    /// <param name="opname">The base operator name</param>
    /// <param name="w">The covering bit width representative</param>
    /// <param name="t">A primal cell type representative</param>
    /// <typeparam name="W">The bit width type</typeparam>
    /// <typeparam name="T">The cell type</typeparam>
    [MethodImpl(Inline)]   
    public static OpIdentity identify<T>(string opname, HK.Vec256<T> hk)
        where T : unmanaged
            => OpIdentities.identify(opname, n256, NumericType.kind<T>());

}
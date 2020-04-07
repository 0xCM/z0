//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes a type-level natural number, a *typenat*
    /// </summary>
    public interface ITypeNat
    {
        /// <summary>
        /// The number's value
        /// </summary>
        ulong NatValue {get;}

    }

    /// <summary>
    /// Characterizes a type with which a natural number type is associated
    /// </summary>
    /// <typeparam name="T">The represented type</typeparam>
    public interface ITypeNat<K> : ITypeNat
        where K: unmanaged, ITypeNat
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphic type nat reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface ITypeNatF<F> : ITypeNat<F>
        where F : unmanaged, ITypeNatF<F>
    {

    }
}
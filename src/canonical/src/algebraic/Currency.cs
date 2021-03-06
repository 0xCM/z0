//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Characterizes a bounded fractional operation provider
    /// </summary>
    /// <typeparam name="T">The primitive type</typeparam>
    public interface ICurrencyOps<T> : IBoundRealOps<T>, IFractionalOps<T> 
        where T : unmanaged

    {

    }

    /// <summary>
    /// Characterizes structural reifications of Currency 
    /// </summary>
    /// <typeparam name="S">The structural reification type</typeparam>
    public interface ICurrency<S> : IBoundReal<S>, IFractional<S>
        where S : ICurrency<S>, new()
    {

    }
}
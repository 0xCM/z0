//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public interface IStateless<F>
    {

    }

    /// <summary>
    /// Characterizes an F-bound polymorphick stateless reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="I">The service contract</typeparam>
    public interface IStateless<F,I> : IStateless<I>
        where F : I, new()
    {

    }
}
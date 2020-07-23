//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes a value imagination service
    /// </summary>
    /// <typeparam name="S">The numeric source type</typeparam>
    /// <typeparam name="T">The numeric target type</typeparam>
    public interface IAs<S,T>
        where T : unmanaged        
    {
        /// <summary>
        /// Presents src:S as dst:T
        /// </summary>
        /// <param name="src">The source value</param>
        T As(S src);

        ref T As(ref S src);
    }

    /// <summary>
    /// Characterizes a numeric value presentation service F-bound polymorphic reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="S">The numeric source type</typeparam>
    /// <typeparam name="T">The numeric target type</typeparam>
    public interface IAs<F,S,T> : IAs<S,T>
        where T : unmanaged
        where F : unmanaged, IAs<F,S,T>        
    {

    }
}
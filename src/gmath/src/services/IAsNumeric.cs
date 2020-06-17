//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    /// <summary>
    /// Characterizes a value presentation service that overlays a value viewed through the lens of one type
    /// as a value viewed through the lens of another.
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public interface IAs<S,T>
    {
        /// <summary>
        /// Presents src:S as dst:T
        /// </summary>
        /// <param name="src">The source value</param>
        T As(S src);
    }
    
    /// <summary>
    /// Characterizes a numeric value presentation service
    /// </summary>
    /// <typeparam name="S">The numeric source type</typeparam>
    /// <typeparam name="T">The numeric target type</typeparam>
    public interface IAsNumeric<S,T> : IAs<S,T>
        where T : unmanaged
        
    {
        ref T As(ref S src);

    }

    /// <summary>
    /// Characterizes a numeric value presentation service F-bound polymorphic reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="S">The numeric source type</typeparam>
    /// <typeparam name="T">The numeric target type</typeparam>
    public interface IAsNumeric<F,S,T> : IAsNumeric<S,T>
        where T : unmanaged
        where F : unmanaged, IAsNumeric<F,S,T>        
    {

    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface IStructuralOperation
    {
        
    }

    /// <summary>
    /// Characterizes a function reified as a (structural) type. 
    /// </summary>
    /// <remarks>
    /// This provides motivation for calling these things structural fuunctions, I suppose
    /// </remarks>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFunc : IStructuralOperation
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISAction<A> : IStructuralOperation
    {
        void Invoke(A a);

        Action<A> Operation => Invoke;
    }    
    /// <summary>
    /// Characterizes a structural function that is width-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWFunc<W> : IStructuralOperation
    {

    }

}
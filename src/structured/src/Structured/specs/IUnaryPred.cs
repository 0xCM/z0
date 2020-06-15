//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Defines trait for a vecorized unary predicate that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPred<T> : IFunc<T,bit>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPred128<T> : IUnaryPred<Vector128<T>>, IFunc128<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPred256<T> : IUnaryPred<Vector256<T>>, IFunc256<T>
        where T : unmanaged
    {        
        
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPred128D<T> : IUnaryPred128<T>, IUnaryPred<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized unary predicate over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPred256D<T> : IUnaryPred256<T>, IUnaryPred<T>
        where T : unmanaged
    {
    
    }    
}
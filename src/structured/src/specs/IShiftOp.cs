//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a vectorized shift operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftOp128<T> : IUnaryImm8Op128<T>, IFunc128<T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftOp256<T> : IUnaryImm8Op256<T>, IFunc256<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftOp128D<T> : IUnaryImm8Op128<T>, IUnaryImm8Op<T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 256-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftOp256D<T> : IUnaryImm8Op256<T>, IUnaryImm8Op<T>
        where T : unmanaged
    {
        
    }
}
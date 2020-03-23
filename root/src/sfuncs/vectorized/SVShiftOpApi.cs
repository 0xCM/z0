//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a vectorized shift operator that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, byte offset);           
    }

    /// <summary>
    /// Characterizes a vectorized shift operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVShiftOpApi<V> : ISVFuncApi, ISImm8UnaryOpApi<V>
        where V : struct
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized shift operator parameterized by operand bit-width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVShiftOpApi<W,V> : ISVShiftOpApi<V>
        where W : unmanaged, ITypeWidth<W>
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized shift operator parameterized by operand bit-width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVShiftOpApi<W,V,T> : ISVShiftOpApi<W,V>
        where W : unmanaged, ITypeWidth<W>
        where V : struct
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVShiftOp128Api<T> : ISVImm8UnaryOp128Api<T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVShiftOp256Api<T> : ISVImm8UnaryOp256Api<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVShiftOp128DApi<T> : ISVImm8UnaryOp128DApi<T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized shift operator over 256-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVShiftOp256DApi<T>  : ISVImm8UnaryOp256DApi<T>
        where T : unmanaged
    {
        
    }
}
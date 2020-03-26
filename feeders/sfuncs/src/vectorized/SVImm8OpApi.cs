//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Defines trait for a vectorized unary immediate operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpImm8D<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, byte b);
    }

    /// <summary>
    /// Defines trait for a vectorized unary doubly-immediate operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpImm8x2D<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, byte b, byte c);
    }

    /// <summary>
    /// Characterizes a unary vectorized operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryOpApi<W,V,T> : ISVFuncApi,  ISImm8UnaryOpApi<V>
        where W : unmanaged, ITypeWidth
    {
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryOp128Api<T> : ISVImm8UnaryOpApi<W128,Vector128<T>,T>, ISVFunc128Api<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryOp256Api<T> : ISVImm8UnaryOpApi<W256,Vector256<T>,T>, ISVFunc256Api<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a unary vectorized operator that accepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8x2UnaryOpApi<W,V,T> : ISVFuncApi, ISImm8x2UnaryOpApi<V>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8x2UnaryOp128Api<T> : ISVImm8x2UnaryOpApi<W128,Vector128<T>,T>, ISVFunc128Api<T>
        where T : unmanaged
    {
                
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8x2UnaryOp256Api<T> : ISVImm8x2UnaryOpApi<W256,Vector256<T>,T>, ISVFunc256Api<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryOp128DApi<T> : ISVImm8UnaryOp128Api<T>, IVUnaryOpImm8D<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8UnaryOp256DApi<T> : ISVImm8UnaryOp256Api<T>, IVUnaryOpImm8D<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8x2UnaryOp128DApi<T> : ISVImm8x2UnaryOp128Api<T>, IVUnaryOpImm8x2D<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8x2UnaryOp256DApi<T> : ISVImm8x2UnaryOp256Api<T>, IVUnaryOpImm8x2D<T>
        where T : unmanaged
    {
        
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Defines trait for vecorized binary operators that are accompanied by componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, T b);
    }

    /// <summary>
    /// Characterizes a binary vectorized operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8BinaryOpApi<W,V,T> : ISVFuncApi, ISWImm8BinaryOpApi<W,V>
        where W : unmanaged, ITypeWidth
    {

    }    
    
    /// <summary>
    /// Characterizes a vectorized binary operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryOpApi<W,V,T> : ISVFuncApi, ISBinaryOpApi<V>
        where W : unmanaged, ITypeWidth
        where V : struct
        where T : unmanaged
    {

    }
    
    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryOp128Api<T> : ISVBinaryOpApi<W128,Vector128<T>,T>, ISVFunc128Api<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryOp256Api<T> : ISVBinaryOpApi<W256,Vector256<T>,T>, ISVFunc256Api<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands that is accompanied by componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryOp128DApi<T> : ISVBinaryOp128Api<T>, IVBinaryOpD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands that is accompanied by componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryOp256DApi<T> : ISVBinaryOp256Api<T>, IVBinaryOpD<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8BinaryOp128Api<T> : ISVImm8BinaryOpApi<W128,Vector128<T>,T>
        where T : unmanaged
    {        
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVImm8BinaryOp256Api<T> : ISVImm8BinaryOpApi<W256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }   
}
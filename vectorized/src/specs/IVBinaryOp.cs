//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Characterizes a binary vectorized operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryOpImm8<W,V,T> : IVFunc, ISFWImm8BinaryOp<W,V>
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
    public interface IVBinaryOp<W,V,T> : IVFunc, IFSBinaryOpApi<V>
        where W : unmanaged, ITypeWidth
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Defines trait for vecorized binary operators that are accompanied by componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOpD<T> : IVDecompositionFacet
        where T : unmanaged
    {
        T InvokeScalar(T a, T b);
    }
    
    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryOp128<T> : IVBinaryOp<W128,Vector128<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryOp256<T> : IVBinaryOp<W256,Vector256<T>,T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands that is accompanied by componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryOp128D<T> : IVBinaryOp128<T>, IVBinOpD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands that is accompanied by componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryOp256D<T> : IVBinaryOp256<T>, IVBinOpD<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryOp128Imm8<T> : IVBinaryOpImm8<W128,Vector128<T>,T>
        where T : unmanaged
    {        
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryOp256Imm8<T> : IVBinaryOpImm8<W256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }   
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Common non-parametric interface for binary operators
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp : IOp
    {
        
    }

    /// <summary>
    /// Characterizes a binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IBinaryOp
    {
        /// <summary>
        /// Invokes the reified binary operator over supplied operands
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        A Invoke(A a, A b);        
    }

    /// <summary>
    /// Characterizes a binary operator over primal operands
    /// </summary>
    /// <typeparam name="T">The primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalBinOp<T> : IPrimalOp<T>, IBinaryOp<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp<V> : IVectorOp<V>, IBinaryOp<V>
        where V : struct
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator parameterized by operand bit width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp<W,V> : IVBinOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp<W,V,T> : IVBinOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Defines trait for a vecorized binary operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, T b);
    }
    
    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp128<T> : IVBinOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp256<T> : IVBinOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp128D<T> : IVBinOp128<T>, IVBinOpD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp256D<T> : IVBinOp256<T>, IVBinOpD<T>
        where T : unmanaged
    {
        
    }
}
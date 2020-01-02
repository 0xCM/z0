//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;
    
    using static zfunc;

    /// <summary>
    /// Characterizes a binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IFunc<A,A,A>
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized binary operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp<W,V,T> : IBinaryOp<V>
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
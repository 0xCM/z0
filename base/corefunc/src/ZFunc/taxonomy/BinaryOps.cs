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
    /// Characterizes a binary function
    /// </summary>
    /// <typeparam name="A">The left operand type</typeparam>
    /// <typeparam name="B">The right operand type</typeparam>
    /// <typeparam name="C">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryFunc<A,B,C> : IFunc<A,B,C>
    {
        
    }

    /// <summary>
    /// Characterizes a binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IBinaryFunc<A,A,A>
    {
    
    }

    /// <summary>
    /// Characterizes a binary operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinOpImm8<A> : IFunc<A,A,byte,A>
    {

    }

    /// <summary>
    /// Characterizes a binary vectorized operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOpImm8<W,V,T> : IBinOpImm8<V>
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
    /// Defines trait for vecorized binary operators that are accompanied by componentwise decomposition/evaluation
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
    /// Characterizes a vectorized binary operator over 128-bit operands that is accompanied by componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp128D<T> : IVBinOp128<T>, IVBinOpD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands that is accompanied by componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp256D<T> : IVBinOp256<T>, IVBinOpD<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 128-bit operands that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp128Imm8<T> : IVBinOpImm8<N128,Vector128<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary operator over 256-bit operands that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp256Imm8<T> : IVBinOpImm8<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }
}
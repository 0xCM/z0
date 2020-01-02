//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    /// <summary>
    /// Characterizes a unary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOp<A> : IFunc<A,A>
    {

    }

    /// <summary>
    /// Characterizes a unary operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOpImm8<A> : IFunc<A,byte,A>
    {

    }


    /// <summary>
    /// Characterizes a unary operator that accepts two integral values that define a range
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    /// <typeparam name="K">The integral value type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryRangeOp<A,K> : IFunc<A,K,K,A>
        where K : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a class of unary operators over a primal operands where
    /// membership within a specific class is discriminated by a natural number
    /// </summary>
    /// <typeparam name="T">The primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface INaturalUnaryOp<N,T> : IUnaryOp<T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        N Discrimintator => default(N);
    }

    /// <summary>
    /// Characterizes a primal unary operator that accepts two unsigned 8-bit values that define a range
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalUnaryRange8Op<T> : IUnaryRangeOp<T,byte>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized unary operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<V> : IUnaryOp<V>
        where V : struct
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator parameterized by operand bit width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<W,V> : IVUnaryOp<V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<W,V,T> : IVUnaryOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Defines trait for a vecorized unary operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a);
    }

    /// <summary>
    /// Defines trait for a vecorized unary operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpImm8D<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, byte imm8);
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128<T> : IVUnaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256<T> : IVUnaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128D<T> : IVUnaryOp128<T>, IVUnaryOpD<T>
        where T : unmanaged
    {
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256D<T> : IVUnaryOp256<T>, IVUnaryOpD<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a unary vectorized operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpImm8<W,V,T> : IUnaryOpImm8<V>
    {

    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128Imm8<T> : IVUnaryOpImm8<N128,Vector128<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256Imm8<T> : IVUnaryOpImm8<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128Imm8D<T> : IVUnaryOp128Imm8<T>, IVUnaryOpImm8D<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256Imm8D<T> : IVUnaryOp256Imm8<T>, IVUnaryOpImm8D<T>
        where T : unmanaged
    {
        
    }

}
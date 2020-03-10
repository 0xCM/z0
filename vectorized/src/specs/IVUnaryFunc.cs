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
    /// Characterizes a vectorized unary operator
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<V> : IVFunc, IUnaryOp<V>
        where V : struct
    {
        FunctionClass IFunc.Class => FunctionClass.UnaryOp | FunctionClass.Vectorized;
   
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
    /// Defines trait for a vectorized unary operator that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpD<T>
        where T : unmanaged
    {
        T InvokeScalar(T a);
    }

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
    /// Characterizes a vectorized unary operator over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128<T> : IVUnaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.UnaryOp | FunctionClass.V128;    
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256<T> : IVUnaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.UnaryOp | FunctionClass.V256;
        
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
        FunctionClass IFunc.Class => FunctionClass.BinaryImm | FunctionClass.Vectorized;
    }

    /// <summary>
    /// Characterizes a unary vectorized operator that accepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOpImm8x2<W,V,T> : IUnaryOpImm8x2<V>
    {
        FunctionClass IFunc.Class => FunctionClass.TernaryImm | FunctionClass.Vectorized;

    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128Imm8<T> : IVUnaryOpImm8<N128,Vector128<T>,T>
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.BinaryImm | FunctionClass.V128;
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128Imm8x2<T> : IVUnaryOpImm8x2<N128,Vector128<T>,T>
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.TernaryImm | FunctionClass.V128;
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256Imm8<T> : IVUnaryOpImm8<N256,Vector256<T>,T>
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.BinaryImm | FunctionClass.V256;
        
    }

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256Imm8x2<T> : IVUnaryOpImm8x2<N256,Vector256<T>,T>
        where T : unmanaged
    {
        FunctionClass IFunc.Class => FunctionClass.TernaryImm | FunctionClass.V256;
        
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
    /// Characterizes a vectorized unary operator over 128-bit operands that acepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128Imm8x2D<T> : IVUnaryOp128Imm8x2<T>, IVUnaryOpImm8x2D<T>
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

    /// <summary>
    /// Characterizes a vectorized unary operator over 256-bit operands that acepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256Imm8x2D<T> : IVUnaryOp256Imm8x2<T>, IVUnaryOpImm8x2D<T>
        where T : unmanaged
    {
        
    }
}
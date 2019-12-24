//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    /// Base operator characterization
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IOp
    {
        /// <summary>
        /// A name that uniquely identifies an operator reification
        /// </summary>
        string Moniker {get;}        
    }

    /// <summary>
    /// Characterizes a unary predicate
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryPred<A> : IOp
    {
        bit Invoke(A a);        
    }

    /// <summary>
    /// Characterizes a binary predicate
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryPred<A> : IOp
    {
        bit Invoke(A a, A b);        
    }

    /// <summary>
    /// Characterizes a ternary predicate 
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryPred<A> : IOp
    {
        bit Invoke(A a, A b, A c);        
    }

    /// <summary>
    /// Characterizes a unary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOp<A> : IOp
    {
        A Invoke(A a);        
    }

    /// <summary>
    /// Characterizes a binary operator
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IOp
    {
        A Invoke(A a, A b);        
    }

    /// <summary>
    /// Characterizes a ternary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ITernaryOp<A> : IOp
    {
        A Invoke(A a, A b, A c);        
    }

    /// <summary>
    /// Characterizes a shift operator
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IShiftOp<A> : IOp
    {
        A Invoke(A a, byte offset);        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<T> : IOp
        where T : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalOp<T> : IOp
        where T : unmanaged
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPUnaryOp<T> : IPrimalOp<T>, IUnaryOp<T>
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPBinOp<T> : IPrimalOp<T>, IBinaryOp<T>
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPUnaryPred<T> : IPrimalOp<T>, IUnaryPred<T>
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPBinaryPred<T> : IPrimalOp<T>, IBinaryPred<T>
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IPShiftOp<T> : IPrimalOp<T>, IShiftOp<T>
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<W,V> : IOp
        where V : struct
        where W : unmanaged, ITypeNat
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<W,V,T> : IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where T : unmanaged
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<V> : IVectorOp<V>, IUnaryOp<V>
        where V : struct
    {
        
    }


    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp<V> : IVectorOp<V>, IBinaryOp<V>
        where V : struct
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<V> : IVectorOp<V>, ITernaryOp<V>
        where V : struct
    {
        
    }


    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryPred<V> : IVectorOp<V>, IUnaryPred<V>
        where V : struct
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinaryPred<V> : IVectorOp<V>, IBinaryPred<V>
        where V : struct
    {
        
    }


    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp<V> : IVectorOp<V>, IShiftOp<V>
        where V : struct
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp<W,V> : IVShiftOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp<W,V,T> : IVShiftOp<W,V>, IVectorOp<W,V,T>    
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        T InvokeScalar(T a, byte offset);           
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp128<T> : IVShiftOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVShiftOp256<T> : IVShiftOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<W,V> : IVUnaryOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp<W,V,T> : IVUnaryOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        T InvokeScalar(T a);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp128<T> : IVUnaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVUnaryOp256<T> : IVUnaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp<W,V> : IVBinOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp<W,V,T> : IVBinOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        T InvokeScalar(T a, T b);
    }
    
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp128<T> : IVBinOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp256<T> : IVBinOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<W,V> : IVTernaryOp<V>, IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp<W,V,T> : IVTernaryOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {
        T InvokeScalar(T a, T b, T c);
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp128<T> : IVTernaryOp<N128,Vector128<T>,T>
        where T : unmanaged
    {
    }

    [SuppressUnmanagedCodeSecurity]
    public interface IVTernaryOp256<T> : IVTernaryOp<N256,Vector256<T>,T>
        where T : unmanaged
    {
        
    }

}
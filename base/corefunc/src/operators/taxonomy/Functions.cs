//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.Intrinsics;

    using static zfunc;

    [SuppressUnmanagedCodeSecurity]
    public interface IFunc
    {
        /// <summary>
        /// A name that uniquely identifies a function reification
        /// </summary>
        string Moniker {get;}        
    }

    public interface IAction<A> : IFunc
    {
        void Invoke(A a);
    }

    /// <summary>
    /// Characterizes an emitter
    /// </summary>
    /// <typeparam name="A">The emission type</typeparam>    
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A> : IFunc
    {
        A Invoke();
    }

    /// <summary>
    /// Characterizes a unary function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A,B> : IFunc
    {
        B Invoke(A a);
    }

    /// <summary>
    /// Characterizes a binary function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A,B,C> : IFunc
    {
        /// <summary>
        /// Invokes the reified function over supplied operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        C Invoke(A a, B b);
    }

    /// <summary>
    /// Characterizes a ternary function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A,B,C,D> : IFunc
    {
        /// <summary>
        /// Invokes the reified function over supplied operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        D Invoke(A a, B b, C c);
    }

    /// <summary>
    /// Characterizes a 4-operand function
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunc<A1,A2,A3,A4,A5> : IFunc
    {
        /// <summary>
        /// Invokes the reified function over supplied operands
        /// </summary>
        /// <param name="a1">The first operand</param>
        /// <param name="a2">The second operand</param>
        /// <param name="a3">The third operand</param>
        /// <param name="a4">The fourth operand</param>
        A5 Invoke(A1 a1, A2 a2, A3 a3, A4 a4);
    }

    /// <summary>
    /// Characterizes a vectorized unary function
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFunc<W1,W2,V1,V2,T1,T2> : IFunc<V1,V2>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where T1 : unmanaged
        where T2 : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary function
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="W3">The bit width type of the result vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="V3">The type of the result vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    /// <typeparam name="T3">The component type of the result vector</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFunc<W1,W2,W3,V1,V2,V3,T1,T2,T3> : IFunc<V1,V2,V3>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where W3 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where V3 : struct
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized ternary function
    /// </summary>
    /// <typeparam name="W1">The bit width type of the first vector</typeparam>
    /// <typeparam name="W2">The bit width type of the second vector</typeparam>
    /// <typeparam name="W3">The bit width type of the third vector</typeparam>
    /// <typeparam name="W4">The bit width type of the result vector</typeparam>
    /// <typeparam name="V1">The type of the first vector</typeparam>
    /// <typeparam name="V2">The type of the second vector</typeparam>
    /// <typeparam name="V3">The type of the third vector</typeparam>
    /// <typeparam name="V4">The type of the result vector</typeparam>
    /// <typeparam name="T1">The component type of the first vector</typeparam>
    /// <typeparam name="T2">The component type of the second vector</typeparam>
    /// <typeparam name="T3">The component type of the third vector</typeparam>
    /// <typeparam name="T4">The component type of the result vector</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVFunc<W1,W2,W3,W4,V1,V2,V3,V4,T1,T2,T3,T4> : IFunc<V1,V2,V3,V4>
        where W1 : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where W3 : unmanaged, ITypeNat
        where W4 : unmanaged, ITypeNat
        where V1 : struct
        where V2 : struct
        where V3 : struct
        where V4 : struct
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a function that produces a 128-bit vector from a 256-bit vector
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVReducer256<T> : IVFunc<N256,N128,Vector256<T>,Vector128<T>,T,T>
        where T : unmanaged
    {


    }
}
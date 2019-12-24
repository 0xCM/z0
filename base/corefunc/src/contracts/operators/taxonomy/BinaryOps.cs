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
    /// Characterizes a binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryOp<A> : IOp
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
    public interface IPBinOp<T> : IPrimalOp<T>, IBinaryOp<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a binary operator over non-primal operands
    /// </summary>
    /// <typeparam name="V">The non-primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVBinOp<V> : IVectorOp<V>, IBinaryOp<V>
        where V : struct
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
}
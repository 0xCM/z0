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
    /// Defines trait for a vecorized binary predicate that supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IBinaryPredicateD<T>
        where T : unmanaged
    {
        bit InvokeScalar(T x, T y);
    }

   /// <summary>
    /// Characterizes a natural binary predicate over non-primal operands
    /// </summary>
    /// <typeparam name="W">The natural type</typeparam>
    /// <typeparam name="V">The non-primal operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryPredicateApi<W,V> : ISVFunc, ISFuncApi<V,V,bit>
        where W : unmanaged, ITypeWidth<W>
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a natural binary predicate over non-primal operands that support scalar application
    /// </summary>
    /// <typeparam name="W">The natural type</typeparam>
    /// <typeparam name="V">The non-primal type</typeparam>
    /// <typeparam name="T">The scalar type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryPredicateApi<W,V,T> : ISVBinaryPredicateApi<W,V>
        where W : unmanaged, ITypeWidth<W>
        where V : struct
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary predicate over 128-bit operands
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryPredicate128Api<T> : ISVBinaryPredicateApi<W128,Vector128<T>,T>, ISVFunc128<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized binary predicate over 256-bit operands
    /// </summary>
    /// <typeparam name="T">The component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryPredicate256Api<T> : ISVBinaryPredicateApi<W256,Vector256<T>,T>, ISVFunc256<T>
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a vectorized binary predicate over 128-bit operands that 
    /// also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryPredicate128DApi<T> : ISVBinaryPredicate128Api<T>, IBinaryPredicateD<T>
        where T : unmanaged
    {
    
    }

    /// <summary>
    /// Characterizes a vectorized binary predicate over 128-bit operands that 
    /// also supports componentwise decomposition/evaluation
    /// </summary>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISVBinaryPredicate256DApi<T> : ISVBinaryPredicate256Api<T>, IBinaryPredicateD<T>
        where T : unmanaged
    {
    
    }
}
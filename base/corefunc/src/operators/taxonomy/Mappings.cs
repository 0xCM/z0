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
    using static zfunc;


    /// <summary>
    /// Characterizes a transformation
    /// </summary>
    /// <typeparam name="A">The source domain type</typeparam>
    /// <typeparam name="B">The target domain type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IMap<A,B>
    {
        /// <summary>
        /// Projects a point in the source domain to a point in the target domain
        /// </summary>
        /// <param name="src">The source domain point</param>
        B Map(A src);
    }

    /// <summary>
    /// Characterizes a transformation between primal types
    /// </summary>
    /// <typeparam name="S">The primal source domain type</typeparam>
    /// <typeparam name="T">The primal target domain type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalMap<S,T> : IMap<S,T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized transformation
    /// </summary>
    /// <typeparam name="U">The source operand type</typeparam>
    /// <typeparam name="T">The target operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVectorMap<U,V> : IMap<U,V>
        where U : struct
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized transformation parameterized by operand bit width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="U">The source operand type</typeparam>
    /// <typeparam name="T">The target operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap<W,U,V> : IVectorMap<U,V>
        where W : unmanaged, ITypeNat
        where U : struct
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized transformation parameterized by common operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="U">The source operand type</typeparam>
    /// <typeparam name="T">The target operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap<W,U,V,T> : IVMap<W,U,V>
        where W : unmanaged, ITypeNat
        where U : struct
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized transformation parameterized by operand source and target bit widths and common component type
    /// </summary>
    /// <typeparam name="WU">The bit-width type of the source operand</typeparam>
    /// <typeparam name="WV">The bit-width type of the target operand</typeparam>
    /// <typeparam name="U">The source operand type</typeparam>
    /// <typeparam name="V">The target operand type</typeparam>
    /// <typeparam name="T">The common component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap<WU,W2,U,V,T> : IVectorMap<U,V>
        where WU : unmanaged, ITypeNat
        where W2 : unmanaged, ITypeNat
        where U : struct
        where V : struct
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a vectorized transformation parameterized by operand source/target bit widths and source/target component types
    /// </summary>
    /// <typeparam name="WU">The bit-width type of the source operand</typeparam>
    /// <typeparam name="WV">The bit-width type of the target operand</typeparam>
    /// <typeparam name="U">The source operand type</typeparam>
    /// <typeparam name="V">The target operand type</typeparam>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap<WU,WV,U,V,S,T> : IVectorMap<U,V>
        where WU : unmanaged, ITypeNat
        where WV : unmanaged, ITypeNat
        where U : struct
        where V : struct
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a 128-bit vectorized transformation parameterized by source/target component types
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap128<S,T> : IVMap<N128,N128,Vector128<S>,Vector128<T>,S,T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a 128-bit vectorized transformation parameterized by a common component type
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap128<T> : IVMap128<T,T>
        where T : unmanaged
    {


    }

    /// <summary>
    /// Characterizes a 256-bit vectorized transformation parameterized by source/target component types
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap256<S,T> : IVMap<N256,N256,Vector256<S>,Vector256<T>,S,T>
        where S : unmanaged
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a 256-bit vectorized transformation parameterized by a common component type
    /// </summary>
    /// <typeparam name="S">The source component type</typeparam>
    /// <typeparam name="T">The target component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVMap256<T> : IVMap256<T,T>
        where T : unmanaged
    {


    }

}
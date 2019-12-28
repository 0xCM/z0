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

    [SuppressUnmanagedCodeSecurity]
    public interface IPrimalOp<T> : IOp
        where T : unmanaged
    {

    }

    /// <summary>
    /// Defines base interface for vectorized operators
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp : IOp
    {

    }

    /// <summary>
    /// Characterizes an operator parameterized by a vectorized operand
    /// </summary>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<V> : IVectorOp
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized operator parameterized by operand bit width
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<W,V> : IOp
        where W : unmanaged, ITypeNat
        where V : struct
    {

    }

    /// <summary>
    /// Characterizes a vectorized operator parameterized by operand bit width and component type
    /// </summary>
    /// <typeparam name="W">The bit-width type</typeparam>
    /// <typeparam name="V">The operand type</typeparam>
    /// <typeparam name="T">The vector component type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IVectorOp<W,V,T> : IVectorOp<W,V>
        where W : unmanaged, ITypeNat
        where V : struct
        where T : unmanaged
    {

    }
}
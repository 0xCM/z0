//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes an identified with-parametric structural function
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWApi<W> : ISFApi
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural emitter with emission type of known width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWApi<W,A> : ISFApi<A>, ISFWApi<W>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a an identified structural unary function with operand and result type of known and common width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWApi<W,A,B> : ISFApi<A,B>, ISFWApi<W>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural binary function with operands and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWApi<W,A,B,C> : ISFApi<A,B,C>, ISFWApi<W>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural ternary function with operands and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWApi<W,A,B,C,D> : ISFApi<A,B,C,D>, ISFWApi<W>
        where W : unmanaged, ITypeWidth
    {

    }
}
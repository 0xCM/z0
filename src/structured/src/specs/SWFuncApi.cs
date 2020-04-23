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
    public interface ISWFuncApi<W> : ISFunc, ISWFunc<W>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes an identified structural emitter with emission type of known width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWFuncApi<W,A> : ISFuncApi<A>, ISWFuncApi<W>, ISWFunc<W,A>
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
    public interface ISWFuncApi<W,A,B> : ISFunc<A,B>, ISWFuncApi<W>, ISWFunc<W,A,B>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes an identified structural binary function with operands and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWFuncApi<W,A,B,C> : ISFuncApi<A,B,C>, ISWFuncApi<W>, ISWFunc<W,A,B,C>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes an identified structural ternary function with operands and return type of known and common widths
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The third operand type</typeparam>
    /// <typeparam name="D">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWFuncApi<W,A,B,C,D> : ISFuncApi<A,B,C,D>, ISWFuncApi<W>, ISWFunc<W,A,B,C,D>
        where W : unmanaged, ITypeWidth
    {

    }
}
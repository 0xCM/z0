//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a structural function that is width-parametric
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFuncW<W> : ISFunc
        where W : unmanaged, ITypeWidth
    {
        TypeWidth TypeWidth => default(W).TypeWidth;

    }

    /// <summary>
    /// Characterizes a structural emitter with emission type of known width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFuncW<W,A> : IFuncW<W>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural unary function with operand and result type of known and common width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The result type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFuncW<W,A,B> : IFuncW<W>
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
    public interface IFuncW<W,A,B,C> : IFuncW<W>
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
    public interface IFuncW<W,A,B,C,D> : IFuncW<W>
        where W : unmanaged, ITypeWidth
    {

    }
}
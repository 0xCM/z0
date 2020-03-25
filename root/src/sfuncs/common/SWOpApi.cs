//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a structural unary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWUnaryOpApi<W,A> : ISUnaryOpApi<A>, ISWFuncApi<W,A,A>, ISWUnaryOp<W,A>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural binary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width kind</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWBinaryOpApi<W,A> : ISBinaryOpApi<A>, ISWFuncApi<W,A,A,A>, ISWBinaryOp<W,A>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural ternary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width kind</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWTernaryOpApi<W,A> : ISTernaryOpApi<A>, ISWFuncApi<W,A,A,A,A>, ISWTernaryOp<W,A>
        where W : unmanaged, ITypeWidth
    {

    }
}
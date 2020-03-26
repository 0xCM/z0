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
    public interface ISWUnaryOp<W,A> : ISWFunc<W,A,A>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural unary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWBinaryOp<W,A> : ISWFunc<W,A,A,A>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural unary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWTernaryOp<W,A> : ISWFunc<W,A,A,A,A>
        where W : unmanaged, ITypeWidth
    {

    }
}
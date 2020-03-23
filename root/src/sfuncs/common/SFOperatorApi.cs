//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a unary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFUnaryOpApi<A> : ISFApi<A,A>
    {
        new UnaryOp<A> Operation => (this as ISFApi<A,A>).Operation.ToUnaryOp();
    }

    /// <summary>
    /// Characterizes a structural unary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFWUnaryOpApi<W,A> : ISFUnaryOpApi<A>, ISFWApi<W,A,A>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFSBinaryOpApi<A> : ISFApi<A,A,A>
    {
        new BinaryOp<A> Operation => (this as ISFApi<A,A,A>).Operation.ToBinaryOp();    
    }

    /// <summary>
    /// Characterizes a structural binary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width kind</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFSWBinaryOpApi<W,A> : IFSBinaryOpApi<A>, ISFWApi<W,A,A,A>
        where W : unmanaged, ITypeWidth
    {

    }

    /// <summary>
    /// Characterizes a structural ternary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFSTernaryOpApi<A> : ISFApi<A,A,A,A>
    {
        new TernaryOp<A> Operation => (this as ISFApi<A,A,A,A>).Operation.ToTernaryOp();
    } 

    /// <summary>
    /// Characterizes a structural ternary operator with a known operand width
    /// </summary>
    /// <typeparam name="W">The width kind</typeparam>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFSWTernaryOpApi<W,A> : IFSTernaryOpApi<A>, ISFWApi<W,A,A,A,A>
        where W : unmanaged, ITypeWidth
    {

    }
}
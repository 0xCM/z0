//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a width-parametric structural operator with one or more immediate operands
    /// </summary>
    /// <typeparam name="W">The width type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8Op<W> : ISWFunc<W>
        where W : unmanaged, ITypeWidth
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8OpApi<W> : ISWFuncApi<W>
        where W : unmanaged, ITypeWidth
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8UnaryOpApi<W,A> : ISImm8UnaryOpApi<A>, ISWImm8OpApi<W>
        where W : unmanaged, ITypeWidth
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8BinaryOpApi<W,A> : ISImm8BinaryOpApi<A>, ISWImm8OpApi<W>
        where W : unmanaged, ITypeWidth
    {

    }
}
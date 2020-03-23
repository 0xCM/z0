//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8Op<W> : ISFuncApi
        where W : unmanaged, ITypeWidth
    {
        TypeWidth WidthKind => default(W).Class;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8UnaryOp<W,A> : ISImm8UnaryOpApi<A>, ISWImm8Op<W>
        where W : unmanaged, ITypeWidth
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8BinaryOp<W,A> : ISFImm8BinaryOpApi<A>, ISWImm8Op<W>
        where W : unmanaged, ITypeWidth
    {

    }
}
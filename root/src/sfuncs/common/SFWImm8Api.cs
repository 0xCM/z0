//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISFWImm8Op<W> : ISFImm8Api
        where W : unmanaged, ITypeWidth
    {
        TypeWidth WidthKind => default(W).Class;
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISFWImm8UnaryOp<W,A> : ISFImm8UnaryOpApi<A>, ISFWImm8Op<W>
        where W : unmanaged, ITypeWidth
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISFWImm8BinaryOp<W,A> : ISFImm8BinaryOpApi<A>, ISFWImm8Op<W>
        where W : unmanaged, ITypeWidth
    {

    }

}
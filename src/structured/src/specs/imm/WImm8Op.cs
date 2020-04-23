//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8Op<W> : IFuncW<W>
        where W : unmanaged, ITypeWidth
    {
        
    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8UnaryOp<W,A> : IUnaryImm8Op<A>, ISWImm8Op<W>
        where W : unmanaged, ITypeWidth
    {

    }

    [SuppressUnmanagedCodeSecurity]
    public interface ISWImm8BinaryOp<W,A> : IBinaryImm8Op<A>, ISWImm8Op<W>
        where W : unmanaged, ITypeWidth
    {

    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPipeRunner : IWfService
    {
        WfExecToken Flow<T>(ReadOnlySpan<T> src, Pipe<T> dst);

        WfExecToken Flow<T>(Pipe<T> src, Pipe<T> dst);
    }
}
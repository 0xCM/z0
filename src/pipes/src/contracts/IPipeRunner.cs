//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IPipeRunner
    {
        uint Flow<T>(ReadOnlySpan<T> src, Pipe<T> dst);

        uint Flow<T>(Pipe<T> src, Pipe<T> dst);
    }
}
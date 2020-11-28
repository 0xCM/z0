//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ISpanProjector<S,T>
    {
        void Project(ReadOnlySpan<S> src, Span<T> dst);
    }
}
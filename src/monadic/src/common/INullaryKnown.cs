//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a type which may or may not have/attain a zero-value
    /// or an otherwise empty state.
    /// </summary>
    public interface INullaryKnown
    {
        bool IsEmpty {get;}

        bool IsNonEmpty => !IsEmpty;
    }
}
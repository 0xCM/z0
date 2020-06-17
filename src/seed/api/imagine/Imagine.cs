//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    /// <summary>
    /// Presents the world as one wishes it to be, though usage could be disastrous if reality and expectation diverge
    /// </summary>
    [ApiHost]
    public readonly partial struct Imagine : IApiHost<Imagine>
    {
        const NumericKind Closure = UnsignedInts;
    }
}
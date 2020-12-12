//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;

    sealed class PipeBuffer<T> : ConcurrentQueue<T>
    {


    }

    [ApiHost]
    public readonly partial struct Pipes
    {
        const NumericKind Closure = AllNumeric;
    }
}

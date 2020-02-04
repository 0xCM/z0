//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public enum SpanKind
    {
        None = 0,

        Mutable = 1,

        Immutable = 2
    }

}
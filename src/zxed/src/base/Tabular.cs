//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct Tabular<F,R> : ITabular<F,R>
        where F : unmanaged, Enum
        where R : ITabular
    {

    }
}
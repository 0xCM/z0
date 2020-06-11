//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface INatNumber<F> : ITypeNatF<F>
        where F : unmanaged, INatNumber<F>
    {

    }

}
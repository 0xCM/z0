//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost(ApiNames.Sigs, true)]
    public readonly partial struct ApiSigs
    {
        static W256 W => default;
    }
}
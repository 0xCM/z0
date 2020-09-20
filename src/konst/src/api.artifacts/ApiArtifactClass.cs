//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using p = Pow2x32;

    public enum ApiArtifactClass : uint
    {
        None = 0,

        ClrRuntime = p.P2ᐞ00,

        CilCode = p.P2ᐞ01,

        AsmCode = p.P2ᐞ02
    }
}
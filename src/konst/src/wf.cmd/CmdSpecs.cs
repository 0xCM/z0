//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CmdSpecs, true)]
    public readonly partial struct CmdSpecs
    {
        internal const string InvalidOption = "Option text invalid";
    }
}
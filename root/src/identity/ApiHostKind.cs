//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Root;

    [Flags]
    public enum ApiHostKind
    {
        None = 0,

        Direct = 1,

        Generic = 2,

        Service = 4,

        DirectAndGeneric = Direct | Generic
    }

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    [ApiHost(ApiNames.ApiCatalogExtensions, true)]
    public static partial class XApiCatalogs
    {
        const NumericKind Closure = UnsignedInts;
    }
}

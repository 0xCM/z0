//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    using Uri = ApiDataUriPart;

    public enum ApiDataUriPart : byte
    {
        OwningPart = 0,

        RowType = 1,
    }

}
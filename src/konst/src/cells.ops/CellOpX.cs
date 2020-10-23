//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity, ApiHost(ApiNames.CellOpX, true)]
    public static partial class CellOpX
    {
        const NumericKind Closure = Integers;
    }
}
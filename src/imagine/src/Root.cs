//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static System.Runtime.Intrinsics.Vector128;
    using static System.Runtime.Intrinsics.Vector256;

    public partial class Root
    {
        const NumericKind Closure = NumericKind.UnsignedInts;
    }
}
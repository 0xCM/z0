//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Konst;

    [ApiHost(ApiNames.Pointers, true)]
    public unsafe readonly partial struct Pointers
    {
        const NumericKind Closure = UnsignedInts;
    }
}
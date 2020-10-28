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

    [ApiHost(ApiNames.SyntaxModels, true)]
    public readonly partial struct SyntaxModels
    {
        const string FencePattern = "<<{0}..{1}>>";

        const NumericKind Closure = UnsignedInts;
    }
}
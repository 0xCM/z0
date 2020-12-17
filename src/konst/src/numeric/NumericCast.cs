//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost("numeric.cast")]
    public readonly partial struct NumericCast
    {
        const NumericKind Closure = AllNumeric;
   }
}
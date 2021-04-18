//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost("numeric.cast")]
    public readonly partial struct NumericCast
    {
        const NumericKind Closure = AllNumeric;
   }
}
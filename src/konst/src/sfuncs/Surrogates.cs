//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.XSFx, true)]
    public static partial class XSFx
    {

    }

    /// <summary>
    /// Defines surrogate api - a facility for defining structural functions over delegates
    /// </summary>
    [ApiHost]
    public partial class Surrogates
    {
        const NumericKind Closure = UnsignedInts;
    }
}
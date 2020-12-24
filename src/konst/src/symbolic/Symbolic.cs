//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    /// <summary>
    /// Defines an api surface for <see cref='ISymbol'/> manipulation
    /// </summary>
    [ApiHost(ApiNames.Symbolic, true)]
    public readonly partial struct Symbolic
    {
        const NumericKind Closure = UnsignedInts;
    }
}
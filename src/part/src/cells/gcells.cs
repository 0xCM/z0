//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [ApiHost]
    public readonly partial struct gcells
    {
        const NumericKind Closure = UnsignedInts;
    }
}
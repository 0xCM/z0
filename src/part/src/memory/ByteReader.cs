//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost]
    public readonly partial struct ByteReader
    {
        const NumericKind Closure = UnsignedInts;
    }
}
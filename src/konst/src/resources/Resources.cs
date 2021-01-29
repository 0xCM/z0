//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.Resources)]
    public readonly partial struct Resources
    {
        const NumericKind Closure = UnsignedInts;

        public static RenderPattern<ContentName> ContentNotFound => "Content resource {0} not found";
    }
}
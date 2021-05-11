//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    public readonly struct Dynops
    {
        public static IDynexus Dynexus => Z0.Dynexus.service();

        const NumericKind Closure = UInt64k;
    }
}
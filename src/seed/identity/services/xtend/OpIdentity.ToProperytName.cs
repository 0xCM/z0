//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static string ToPropertyName(this OpIdentity src)
            => LegalIdentityBuilder.code(src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XApi
    {
         [Op]
         public static string ToPropertyName(this OpIdentity src)
            => LegalIdentityBuilder.code(src);
    }
}
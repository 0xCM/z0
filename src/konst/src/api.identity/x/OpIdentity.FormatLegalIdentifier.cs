//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XApiId
    {
         [Op]
         public static string FormatLegalIdentifier(this OpIdentity src)
            => LegalIdentityBuilder.code(src);
    }
}
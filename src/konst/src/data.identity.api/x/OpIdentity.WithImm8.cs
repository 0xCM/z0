//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XApiIdentity
    {
        /// <summary>
        /// Attaches an immediate suffix to an identity, removing an existing immediate suffix if necessary
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="immval">The immediate value to attach</param>
        public static OpIdentity WithImm8(this OpIdentity src, byte immval)
            => ApiIdentityParser.parse(text.concat(src.WithoutImm8().Identifier, ApiUri.Imm8Suffix(immval)));
    }
}

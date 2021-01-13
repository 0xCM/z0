//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XApiIdentity
    {
        [MethodImpl(Inline)]
        public static OpIdentity Generalize(this ApiGenericOpIdentity src)
            => OpIdentityParser.parse(src.Identifier);
    }
}
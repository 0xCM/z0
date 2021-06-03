//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XApiId
    {
        [MethodImpl(Inline)]
        public static OpIdentity Generalize(this OpIdentityG src)
            => ApiUri.opid(src.IdentityText);
    }
}
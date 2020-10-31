//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    /// <summary>
    /// Divines delegate identity
    /// </summary>
    readonly struct DelegateIdentityDiviner : IDelegateIdentityDiviner
    {
        public OpIdentity DivineIdentity(Delegate src)
            => Identity.identify(src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Divines delegate identity
    /// </summary>
    readonly struct DelegateIdentityDiviner : IDelegateIdentityDiviner
    {
        public static IDelegateIdentityDiviner Service => default(DelegateIdentityDiviner);

        public OpIdentity DivineIdentity(Delegate src)
            => Identity.identify(src);
    }
}
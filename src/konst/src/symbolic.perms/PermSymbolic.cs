//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static PermLits;

    [ApiHost(ApiNames.PermSymbolic, true)]
    public readonly partial struct PermSymbolic
    {

        [MethodImpl(Inline), Op]
        public static Perm8L permid(N8 n)
            => Perm8Identity;

        [MethodImpl(Inline), Op]
        public static Perm16L permid(N16 n)
            => Perm16Identity;
    }
}
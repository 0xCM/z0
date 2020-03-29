//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public static partial class PermX
    {                
        public static NatPerm<N4> ToNatural(this Perm4L src)
            => Z0.Permute.natural(src);

        public static NatPerm<N8> ToNatural(this Perm8L src)
            => Z0.Permute.natural(src);

        public static NatPerm<N16> ToNatural(this Perm16L src)
            => Z0.Permute.natural(src);
    }
}
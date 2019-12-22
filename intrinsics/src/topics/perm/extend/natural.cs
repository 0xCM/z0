//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    public static partial class PermX
    {                

        public static NatPerm<N4> ToNatural(this Perm4L src)
            => Perms.natural(src);

        public static NatPerm<N8> ToNatural(this Perm8L src)
            => Perms.natural(src);

        public static NatPerm<N16> ToNatural(this Perm16L src)
            => Perms.natural(src);

    }

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;

    partial class Permute
    {
        [MethodImpl(Inline), Op]
        public static Perm32 unsize(in NatPerm<N32,byte> spec)
            => new Perm32(V0.vload(n256, spec.Terms));

        [MethodImpl(Inline), Op]
        public static Perm16 unsize(in NatPerm<N16,byte> spec)
            => new Perm16(V0.vload(n128, spec.Terms));
    }
}
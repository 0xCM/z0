//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class BitGrid
    {        

        [MethodImpl(Inline), Op]
        public static Perm16L perm(BitGrid64<N16,N4,ulong> g)
            => (Perm16L)g.Content;
    }
}
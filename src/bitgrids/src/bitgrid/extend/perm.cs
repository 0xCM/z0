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

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static SubGrid32<N8,N3,uint> ToSubGrid(this NatPerm<N8> src)
            => SubGrid.init(src);            

        [MethodImpl(Inline)]
        public static SubGrid32<N8,N3,uint> ToSubGrid(this Perm8L src)
            => (uint)src;

        [MethodImpl(Inline)]
        public static Perm8L ToPerm(this SubGrid32<N8,N3,uint> src)
            => (Perm8L)src.Content;

        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> ToBitGrid(this NatPerm<N16> src)
            => BitGrid.define(src);

        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,ulong> ToBitGrid(this Perm16L src)
            => (ulong)src;

        [MethodImpl(Inline)]
        public static Perm16L ToPerm(this BitGrid64<N16,N4,ulong> src)
            => (Perm16L)src.Content;
    }
}
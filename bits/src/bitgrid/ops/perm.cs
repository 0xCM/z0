//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {        

        [MethodImpl(Inline)]
        public static BitGrid32<uint> from(Perm8 src)
            => (uint)src;


        [MethodImpl(Inline)]
        public static BitGrid64<N16,N4,long> from(Perm16 src)
            => (ulong)src;

        
        [MethodImpl(Inline)]
        public static Perm16 perm(BitGrid64<N16,N4,long> src)
            => (Perm16)src.Data;
    }

}
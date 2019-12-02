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
        public static BitGrid64<T> rotl<M,N,T>(BitGrid64<M,N,T> gx, int shift)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var gz = new BitGrid64<T>(0ul);
            gcells.rotl(in gx.Head, shift, ref gz.Head, gx.CellCount);
            return gz;
        }



    }
}

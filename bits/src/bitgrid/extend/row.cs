//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        public static BitVector<N,T> Row<M,N,T>(this BitGrid64<M,N,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => BitGrid.row(g,index);


    }

}
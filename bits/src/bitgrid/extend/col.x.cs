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
        public static BitVector<N16,ushort> Col<T>(this BitGrid64<N16,N4,T> g, int index)
            where T : unmanaged
                => BitGrid.col(g,index);

    }

}
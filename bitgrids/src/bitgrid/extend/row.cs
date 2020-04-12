//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    partial class XTend
    {                

        [MethodImpl(Inline)]
        public static BitVector<N,T> Row<M,N,T>(this BitGrid64<M,N,T> g, int index)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => BitGrid.row(g,index);
    }
}
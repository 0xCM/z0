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
        public static ref readonly BitGrid<T> not<T>(in BitGrid<T> gx, in BitGrid<T> gz)
            where T : unmanaged
        {
            var blocks = gz.BlockCount;
            for(var i=0; i<blocks; i++)
                gz[i] = ginx.vnot(gx[i]);
            return ref gz;
        }

        [MethodImpl(Inline)]
        public static BitGrid<T> not<T>(in BitGrid<T> gx)
            where T : unmanaged
                => not(gx, alloc<T>(gx.RowCount, gx.ColCount));

        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> not<M,N,T>(in BitGrid<M,N,T> gx, in BitGrid<M,N,T> gz)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var blocks = gz.BlockCount;
            for(var i=0; i<blocks; i++)
                gz[i] = ginx.vnot(gx[i]);
            return ref gz;
        }

        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> not<M,N,T>(in BitGrid<M,N,T> gx)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => not(gx, alloc<M,N,T>());


    }

}
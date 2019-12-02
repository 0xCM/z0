//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitGrid
    {
        [MethodImpl(Inline)]
        public static bit same<M,N,T>(in BitGrid<M,N,T> gx, in BitGrid<M,N,T> gy)
            where T : unmanaged
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
        {
            var blocks = gx.BlockCount;
            for(var i=0; i<blocks; i++)
                if(!ginx.vsame(gx[i],gy[i]))
                       return false;
            return true;        
        }

        [MethodImpl(Inline)]
        public static bit same<T>(in BitGrid<T> gx, in BitGrid<T> gy)
            where T : unmanaged
        {
            var blocks = gx.BlockCount;
            for(var i=0; i<blocks; i++)
                if(!ginx.vsame(gx[i],gy[i]))
                       return false;
            return true;        
        }


    }

}
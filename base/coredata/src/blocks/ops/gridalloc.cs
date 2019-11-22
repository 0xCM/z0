//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        [MethodImpl(Inline)]   
        public static NatGrid<M,N,T> gridalloc<M,N,T>(T fill = default(T), M m = default, N n = default) 
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatGrid<M,N,T>(fill);

        [MethodImpl(Inline)]   
        public static NatGrid<M,N,T> gridalloc<M,N,T>(M m, N n, T fill = default) 
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatGrid<M,N,T>(fill);


    }

}
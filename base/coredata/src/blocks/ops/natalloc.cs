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
        public static NatBlock<N,T> natalloc<N,T>() 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(default(T));

        [MethodImpl(Inline)]   
        public static NatBlock<N,T> natalloc<N,T>(N n, T fill) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(fill);

    }

}
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

    partial class BitGrid
    {
                
        [MethodImpl(Inline)]
        public static void fill<T>(BitGrid<T> grid, bit state)    
            where T : unmanaged
                => grid.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());

        [MethodImpl(Inline)]
        public static void fill<M,N,T>(BitGrid<M,N,T> grid, bit state)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => grid.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());

    }

}
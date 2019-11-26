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
        public static BitGrid128<M,N,T> fill<M,N,T>(in BitGrid128<M,N,T> grid, T cell)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => ginx.vbroadcast(n128,cell);

        [MethodImpl(Inline)]
        public static BitGrid256<M,N,T> fill<M,N,T>(in BitGrid256<M,N,T> grid, T cell)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => ginx.vbroadcast(n256,cell);
                
        [MethodImpl(Inline)]
        public static BitGrid<M,N,T> fill<M,N,T>(in BitGrid<M,N,T> grid, T cell)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {            
            grid.Data.Fill(cell);
            return grid;
        }

        [MethodImpl(Inline)]
        public static BitGrid<T> fill<T>(in BitGrid<T> grid, T cell)    
            where T : unmanaged
        {
            grid.Data.Fill(cell);
            return grid;
        }

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
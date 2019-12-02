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
        public static ref readonly BitGrid<T> broadcast<T>(T cell, in BitGrid<T> dst)            
            where T : unmanaged
        {
            dst.Data.Fill(cell);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid<T> broadcast<T>(bit state, in BitGrid<T> dst)    
            where T : unmanaged
        {
            dst.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());            
            return ref dst;
        }


        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> broadcast<M,N,T>(T cell, in BitGrid<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst.Data.Fill(cell);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly BitGrid<M,N,T> broadcast<M,N,T>(bit state, in BitGrid<M,N,T> dst)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            dst.Data.Fill(state ? gmath.maxval<T>() : gmath.zero<T>());
            return ref dst;
        }

    }
}
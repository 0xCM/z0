//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct BitFlow
    {
        [Free]
        public interface ITuple
        {
            uint N  {get;}
        }

        [Free]
        public interface ITuple<N> : ITuple
            where N : unmanaged, ITypeNat
        {
            uint ITuple.N
                => Typed.nat32u<N>();
        }

        [Free]
        public interface ITuple<F,N> : ITuple<N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, ITuple<F,N>
        {

        }

        [Free]
        public interface ITuple<F,N,T0> : ITuple<F,N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, ITuple<F,N,T0>
            where T0 : unmanaged
        {

        }

        [Free]
        public interface ITuple<F,N,T0,T1> : ITuple<F,N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, ITuple<F,N,T0,T1>
            where T0 : unmanaged
            where T1 : unmanaged
        {

        }

        [Free]
        public interface ITuple<F,N,T0,T1,T2> : ITuple<F,N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, ITuple<F,N,T0,T1,T2>
            where T0 : unmanaged
            where T1 : unmanaged
            where T2 : unmanaged
        {

        }

       [Free]
        public interface ITuple<F,N,T0,T1,T2,T3> : ITuple<F,N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, ITuple<F,N,T0,T1,T2,T3>
            where T0 : unmanaged
            where T1 : unmanaged
            where T2 : unmanaged
            where T3 : unmanaged
        {

        }
    }
}
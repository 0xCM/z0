//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial struct Blit
    {
        [Free]
        public interface IList
        {
            uint N  {get;}
        }

        [Free]
        public interface IList<N> : IList
            where N : unmanaged, ITypeNat
        {
            uint IList.N
                => Typed.nat32u<N>();
        }

        [Free]
        public interface IList<F,N> : IList<N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, IList<F,N>
        {

        }

        [Free]
        public interface IList<F,N,T0> : IList<F,N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, IList<F,N,T0>
            where T0 : unmanaged
        {

        }

        [Free]
        public interface IList<F,N,T0,T1> : IList<F,N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, IList<F,N,T0,T1>
            where T0 : unmanaged
            where T1 : unmanaged
        {

        }

        [Free]
        public interface IList<F,N,T0,T1,T2> : IList<F,N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, IList<F,N,T0,T1,T2>
            where T0 : unmanaged
            where T1 : unmanaged
            where T2 : unmanaged
        {

        }


       [Free]
        public interface IList<F,N,T0,T1,T2,T3> : IList<F,N>
            where N : unmanaged, ITypeNat
            where F : unmanaged, IList<F,N,T0,T1,T2,T3>
            where T0 : unmanaged
            where T1 : unmanaged
            where T2 : unmanaged
            where T3 : unmanaged
        {

        }

    }
}
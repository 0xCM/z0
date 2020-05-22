//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    public interface IReg64 : IRegModel<W64>
    {
        const uint Width = 64;
    }

    public interface IReg64<S> : IReg64, IRegModel<W64,S>
        where S : unmanaged
    {

    }

    public interface IReg64<F,N,S> : IReg64<S>, IRegModel<F,W64,S>
        where F : unmanaged, IReg64<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
        int IRegModel.Index => (int)Memories.value<N>();
    }

    public interface IReg64<F,N> : IReg64<F,N,Fixed64>
        where F : unmanaged, IReg64<F,N>
        where N : unmanaged, ITypeNat
    {

    }

}
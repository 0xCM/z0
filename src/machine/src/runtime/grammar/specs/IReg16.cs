//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    public interface IReg16 : IRegModel<W16>
    {
        const uint Width = 16;
    }

    public interface IReg16<S> : IReg16, IRegModel<W16,S>
        where S : unmanaged
    {

    }


    public interface IReg16<F,N,S> : IReg16<S>,IRegModel<F,W16,S>, ISlotted<N>
        where F : unmanaged, IReg16<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
        int IRegModel.Index => (int)Memories.value<N>();

    }

    public interface IReg16<F,N> : IReg16<F,N,Fixed16>
        where F : unmanaged, IReg16<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}
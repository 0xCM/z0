//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    public interface IReg32 : IRegModel<W32>
    {
        const uint Width = 32;
    }

    public interface IReg32<S> : IReg32, IRegModel<W32,S>
        where S : unmanaged
    {

    }

    public interface IReg32<F,N,S> : IReg32<S>, IRegModel<F,W32,S>,  ISlotted<N>
        where F : unmanaged, IReg32<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
        int IRegModel.Index => (int)Memories.value<N>();

    }

    public interface IReg32<F,N> : IReg16<F,N,Fixed32>
        where F : unmanaged, IReg32<F,N>
        where N : unmanaged, ITypeNat
    {

    }

}
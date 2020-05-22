//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    public interface IReg8 : IRegModel<W8>
    {
        const uint Width = 8;
    }

    public interface IReg8<S> : IReg8, IRegModel<W8,S>
        where S : unmanaged
    {            
    
    }

    public interface IReg8<F,N,S> : IReg8<S>, IRegModel<F,W8,S>, ISlotted<N>
        where F : unmanaged, IReg8<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
        int IRegModel.Index => (int)Memories.value<N>();
        
    }

    public interface IReg8<F,N> : IReg8<F,N,Fixed8>
        where F : unmanaged, IReg8<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}
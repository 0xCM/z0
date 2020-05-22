// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using Z0.Asm.Data;

    public interface IZmmReg : IRegModel<W512>
    {
        const uint Width = 512;

        RegisterKind IRegModel.Kind => RegisterKind.Zmm;
    }

    public interface IZmmReg<F,N,S> : IZmmReg, IRegModel<F,W512,S>, ISlotted<N> 
        where F : struct, IZmmReg<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
        int IRegModel.Index => (int)Memories.value<N>();
    
    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IZmmReg<F,N> : IZmmReg<F,N,Fixed512>
        where F : struct, IZmmReg<F,N>
        where N : unmanaged, ITypeNat
    {
        
    }
}
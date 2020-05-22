// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using Z0.Asm.Data;

    public interface IXmmReg : IRegModel<W128>
    {
        const uint Width = 128;

        RegisterKind IRegModel.Kind => RegisterKind.Xmm;
    }

    public interface IXmmReg<S> : IXmmReg, IRegModel<W128,S>
        where S : unmanaged
    {            
    
    }

    public interface IXmmReg<F,N,S> : IXmmReg<S>, IRegModel<F,W128,S>, ISlotted<N> 
        where F : struct, IXmmReg<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
        int IRegModel.Index => (int)Memories.value<N>();

    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IXmmReg<F,N> : IXmmReg<F,N,Fixed128> 
        where F : struct, IXmmReg<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}
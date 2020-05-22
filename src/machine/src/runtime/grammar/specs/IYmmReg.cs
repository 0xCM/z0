// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using Z0.Asm.Data;

    public interface IYmmReg : IRegModel<W256>
    {
        const uint Width = 256;

        RegisterKind IRegModel.Kind => RegisterKind.Ymm;
    }

    public interface IYmmReg<S> : IYmmReg, IRegModel<W256,S>
        where S : unmanaged
    {            
    
    }

    public interface IYmmReg<F,N,S> : IYmmReg<S>,IRegModel<F,W256,S>,  ISlotted<N> 
        where F : struct, IYmmReg<F,N,S>
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
    public interface IYmmReg<F,N> : IYmmReg<F,N,Fixed256>
        where F : struct, IYmmReg<F,N>
        where N : unmanaged, ITypeNat
    {
        
    }

}
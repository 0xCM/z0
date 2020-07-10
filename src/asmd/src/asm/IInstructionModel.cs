//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IInstructionModel
    {
        Mnemonic Mnemonic {get;}        
    }
    
    public interface IInstructionModel<F> : IInstructionModel
        where F : unmanaged, IInstructionModel<F>
    {

    }
}
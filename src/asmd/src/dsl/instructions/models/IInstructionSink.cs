//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IInstructionSink
    {
        void Deposit(in Instruction src);        

        Mnemonic Kind {get;}
    }
    
    public interface IInstructionSink<M> : IInstructionSink
        where M : unmanaged, IInstructionModel   
    {
        M Model 
            => default;    

        Mnemonic IInstructionSink.Kind 
            => Model.Mnemonic;
    }

    public interface IInstructionHSink<F,M> : IInstructionSink<M>
        where F : struct, IInstructionHSink<F,M>
        where M : unmanaged, IInstructionModel
    {

    }
}
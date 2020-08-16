//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IImmAddress<W,A> : IAsmImmOperand
        where W : unmanaged, IDataWidth
        where A : unmanaged, IAddress
    {
        A ToAddress();
    }

    public interface IImm8Address8<F> : IAsmImmOperand<F,W8,Imm8>, IImmAddress<W8,Address8>
        where F : unmanaged, IImm8Address8<F>
    {
        
    }

    public interface IImmAddress16<F> : IAsmImmOperand<F,W16,Imm16>, IImmAddress<W16,Address16>
        where F : unmanaged, IImmAddress16<F>
    {
        

    }

    public interface IImmAddress32<F> : IAsmImmOperand<F,W32,Imm32>, IImmAddress<W32,Address32>
        where F : unmanaged, IImmAddress32<F>
    {
        

    }

    public interface IImmAddress64<F> : IAsmImmOperand<F,W64,Imm64>, IImmAddress<W64,Address64>
        where F : unmanaged, IImmAddress64<F>
    {        

    }    
}
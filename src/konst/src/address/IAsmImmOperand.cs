//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IAsmImmOperand : IAsmOperand
    {
        AsmOperandKind IAsmOperand.OpKind 
            => AsmOperandKind.Imm;
    }

    public interface IAsmImmOperand<T> : IAsmImmOperand, IAsmOperand<T>
        where T : unmanaged
    {
        
    }

    public interface IAsmImmOperand<W,T> : IAsmImmOperand<T>, IAsmOperand<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    public interface IAsmImmOperand<F,W,T> : IAsmImmOperand<W,T>, IAsmOperand<F,W,T>
        where F : unmanaged, IAsmImmOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }
}
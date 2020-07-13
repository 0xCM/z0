//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IImmOperand : IOperand
    {
        AsmOperandKind IOperand.OpKind 
            => AsmOperandKind.Imm;
    }

    public interface IImmOperand<T> : IImmOperand, IOperand<T>
        where T : unmanaged
    {
        
    }

    public interface IImmOperand<W,T> : IImmOperand<T>, IOperand<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    public interface IImmOperand<F,W,T> : IImmOperand<W,T>, IOperand<F,W,T>
        where F : unmanaged, IImmOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }
}
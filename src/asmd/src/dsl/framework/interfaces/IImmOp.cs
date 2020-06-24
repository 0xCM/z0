//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IImmOp : IOperand
    {
        OperandKind IOperand.OpKind 
            => OperandKind.Imm;
    }

    public interface IImmOp<T> : IImmOp, IOperand<T>
        where T : unmanaged
    {
        
    }

    public interface IImmOp<W,A> : IImmOp
        where W : unmanaged, IDataWidth
        where A : unmanaged, IAddress<W>
    {
        A ToAddress();
    }

    public interface IImmOp<F,W,T> : IImmOp<T>, IOperand<F,W,T>
        where F : unmanaged, IImmOp<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    public interface IImmOp8<F> : IImmOp<F,W8,byte>, IImmOp<W8,Address8>
        where F : unmanaged, IImmOp8<F>
    {
        
    }

    public interface IImmOp16<F> : IImmOp<F,W16,ushort>, IImmOp<W16,Address16>
        where F : unmanaged, IImmOp16<F>
    {
        

    }

    public interface IImmOp32<F> : IImmOp<F,W32,uint>, IImmOp<W32,Address32>
        where F : unmanaged, IImmOp32<F>
    {
        

    }

    public interface IImmOp64<F> : IImmOp<F,W64,ulong>, IImmOp<W64,Address64>
        where F : unmanaged, IImmOp64<F>
    {        

    }
}
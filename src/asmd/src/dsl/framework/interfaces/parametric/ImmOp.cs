//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IImmOp<T> : IImmOp, IOperand<T>
        where T : unmanaged
    {
        
    }

    public interface IImmOp<W,T> : IImmOp<T>, IOperand<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    public interface IImmOp<F,W,T> : IImmOp<W,T>, IOperand<F,W,T>
        where F : unmanaged, IImmOp<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }
        
}
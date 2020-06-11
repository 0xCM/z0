//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    using static Konst;

    public interface IImmOp : IOperand
    {
        OperandKind IOperand.OpKind 
            => OperandKind.Imm;
    }

    public interface IImmOp<T> : IImmOp, IOperand<T>
        where T : unmanaged, IFixed
    {
        
    }

    public interface IImmOp<W,T> : IImmOp<T>, IOperand<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged, IFixed
    {
        
    }

    public interface IImmOp<F,W,T> : IImmOp<W,T>, IOperand<F,W,T>
        where F : unmanaged, IImmOp<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged, IFixed
    {
        
    }

    public interface IImmOp8<F> : IImmOp<F,W8,Fixed8>
        where F : unmanaged, IImmOp8<F>
    {

    }

    public interface IImmOp16<F> : IImmOp<F,W16,Fixed16>
        where F : unmanaged, IImmOp16<F>
    {

    }

    public interface IImmOp32<F> : IImmOp<F,W32,Fixed32>
        where F : unmanaged, IImmOp32<F>
    {

    }

    public interface IImmOp64<F> : IImmOp<F,W64,Fixed64>
        where F : unmanaged, IImmOp64<F>
    {

    }
}
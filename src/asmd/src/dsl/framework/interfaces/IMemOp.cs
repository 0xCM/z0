//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IMemOp : IOperand
    {
        OperandKind IOperand.OpKind 
            => OperandKind.M;
    }

    public interface IMemOp8 : IMemOp, IMemOp<W8,byte>
    {

    }
}
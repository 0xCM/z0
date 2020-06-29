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


    public interface IImm8Op : IImmOp
    {

    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        

    public interface IOperand : ISized
    {
        /// <summary>
        /// The operand sort
        /// </summary>
        OperandKind OpKind {get;}
    }
}
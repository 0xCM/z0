//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes a register
    /// </summary>
    public interface IRegOp : IOperand
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegisterKind Kind {get;}

        RegisterCode Code 
            => (RegisterCode)((byte)Kind);

        RegisterClass Class
            => default;

        OperandKind IOperand.OpKind 
            => OperandKind.R;
    }
}
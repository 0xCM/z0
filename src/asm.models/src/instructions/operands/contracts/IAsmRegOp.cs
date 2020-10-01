//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmRegOp : IAsmOperand
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegisterKind Register {get;}

        AsmOperandKind IAsmOperand.OpKind
            => AsmOperandKind.R;
    }

    public interface IAsmRegOp<T> : IAsmRegOp, IAsmOperand<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IAsmRegOp<W,T> : IAsmRegOp<T>, IAsmOperand<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}
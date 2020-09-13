//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes a register operand
    /// </summary>
    public interface IRegOperand : IAsmArg
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegisterKind Kind {get;}

        RegisterCode Code
            => (RegisterCode)((byte)Kind);

        RegisterClass Class
            => default;

        AsmOperandKind IAsmArg.OpKind
            => AsmOperandKind.R;
    }

    public interface IRegOperand<T> : IRegOperand, IAsmArg<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegArg<W,T> : IRegOperand<T>, IAsmArg<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric and state-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOperand<F,W,T> : IRegArg<W,T>
        where F : struct, IRegOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}
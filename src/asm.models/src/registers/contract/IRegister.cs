//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes a register operand
    /// </summary>
    public interface IRegister : IAsmArg
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

    public interface IRegister<T> : IRegister, IAsmArg<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegister<W,T> : IRegister<T>, IAsmArg<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric and state-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegister<F,W,T> : IRegister<W,T>
        where F : struct, IRegister<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}
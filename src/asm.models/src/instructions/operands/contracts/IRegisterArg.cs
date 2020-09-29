//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegisterArg : IAsmArg
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegisterKind Register {get;}

        AsmOperandKind IAsmArg.OpKind
            => AsmOperandKind.R;
    }

    public interface IRegisterArg<T> : IRegisterArg, IAsmArg<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegisterArg<W,T> : IRegisterArg<T>, IAsmArg<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}
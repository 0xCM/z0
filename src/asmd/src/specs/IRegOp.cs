//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
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

        OperandKind IOperand.OpKind => OperandKind.R;

    }

    /// <summary>
    /// Characerizes a register of parametric width
    /// </summary>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<W> : IRegOp, ISized<W>
        where W : unmanaged, IDataWidth
    {
        
    }

    /// <summary>
    /// Characterizes a width-parametric register reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<W,S> : IRegOp<W>
        where W : unmanaged, IDataWidth
        where S : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric and state-parametric register reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<F,W,S> : IRegOp<W,S>
        where F : struct, IRegOp<F,W,S>
        where W : unmanaged, IDataWidth
        where S : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a register reification parametric in index, width and state
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<F,N,W,S> : IRegOp<F,W,S>
        where F : struct, IRegOp<F,N,W,S>
        where W : unmanaged, IDataWidth
        where S : unmanaged
        where N : unmanaged, ITypeNat
    {

    }
}
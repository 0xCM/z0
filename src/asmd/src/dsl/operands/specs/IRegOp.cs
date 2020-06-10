//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Konst;
    using static Memories;

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

    /// <summary>
    /// Characerizes a register of parametric width
    /// </summary>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<W> : IRegOp, ISized<W>
        where W : unmanaged, IDataWidth
    {
        DataWidth ISized.Width 
            => (DataWidth)Widths.data<W>();        
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
}
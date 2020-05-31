//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using Z0.Asm.Data;

    /// <summary>
    /// Characterizes a register
    /// </summary>
    public interface IRegOp : IOpData
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegisterKind Kind {get;}

        string Name {get;}

        int Index {get;}

    }

    /// <summary>
    /// Characerizes a register of parametric width
    /// </summary>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<W> : IRegOp, IOpData<W>
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
        string IRegOp.Name => typeof(F).Name;
    }

    /// <summary>
    /// Characterizes a register reification parametric in index, width and state
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<F,N,W,S> : IRegOp<F,W,S>, ISlotted<N>
        where F : struct, IRegOp<F,N,W,S>
        where W : unmanaged, IDataWidth
        where S : unmanaged
        where N : unmanaged, ITypeNat
    {

    }
}
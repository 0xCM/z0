//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using Z0.Asm.Data;

    /// <summary>
    /// Characterizes a register
    /// </summary>
    public interface IRegModel : IData
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
    public interface IRegModel<W> : IRegModel, IData<W>
        where W : unmanaged, IDataWidth
    {

    }

    /// <summary>
    /// Characterizes a width-parametric register reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegModel<W,S> : IRegModel<W>
        where W : unmanaged, IDataWidth
        where S : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric and state-parametric register reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegModel<F,W,S> : IRegModel<W,S>
        where F : struct, IRegModel<F,W,S>
        where W : unmanaged, IDataWidth
        where S : unmanaged
    {
        string IRegModel.Name => typeof(F).Name;
    }

    /// <summary>
    /// Characterizes a register reification parametric in index, width and state
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegModel<F,N,W,S> : IRegModel<F,W,S>, ISlotted<N>
        where F : struct, IRegModel<F,N,W,S>
        where W : unmanaged, IDataWidth
        where S : unmanaged
        where N : unmanaged, ITypeNat
    {

    }
}
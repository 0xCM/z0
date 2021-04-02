//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes a register representation
    /// </summary>
    public interface IRegister
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegKind RegKind {get;}

        RegIndex Index
            => (RegIndex)((byte)RegKind);
    }

    public interface IReg<T> : IRegister, IContented<T>
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IReg<W,T> : IReg<T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    /// <summary>
    /// Characterizes a width-parametric and state-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IReg<F,W,T> : IReg<W,T>
        where F : struct, IReg<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    public interface IReg<F,W,T,N> : IReg<F,W,T>
        where F : struct, IReg<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        RegIndex IRegister.Index
            => (RegIndex)TypeNats.nat8u<N>();
    }
}
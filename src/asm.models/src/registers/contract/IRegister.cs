//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes a register operand
    /// </summary>
    public interface IRegister
    {
        /// <summary>
        /// The register's kind classifier
        /// </summary>
        RegisterKind Kind {get;}

        RegisterCode Code
            => (RegisterCode)((byte)Kind);

        RegisterClass Class
            => default;
    }

    public interface IRegister<T> : IRegister
        where T : unmanaged
    {
        /// <summary>
        /// The operand value
        /// </summary>
        T Content {get;}
    }

    /// <summary>
    /// Characterizes a width-parametric register operand reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegister<W,T> : IRegister<T>
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

    public interface IRegister<F,W,T,N> : IRegister<F,W,T>
        where F : struct, IRegister<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegister.Code
            => (RegisterCode)z.nat8u<N>();
    }
}
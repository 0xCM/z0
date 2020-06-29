//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Characterizes a width-parametric register reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<W,T> : IRegOp, IOperand<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes a width-parametric and state-parametric register reification
    /// </summary>
    /// <typeparam name="F">The reifying type</typeparam>
    /// <typeparam name="W">The register width</typeparam>
    public interface IRegOp<F,W,T> : IRegOp<W,T>
        where F : struct, IRegOp<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    public interface IRegOp8<F,T> : IRegOp8
        where F : unmanaged, IRegOp8<F,T>
        where T : unmanaged
    {

    }        

    public interface IRegOp16<F,T> : IRegOp16
        where F : unmanaged, IRegOp16<F,T>
        where T : unmanaged
    {
    }    

    public interface IRegOp32<F,T> : IRegOp32
        where F : unmanaged, IRegOp32<F,T>
        where T : unmanaged
    {

    }    

    public interface IRegOp64<F,T> : IRegOp64
        where F : unmanaged, IRegOp64<F,T>
        where T : unmanaged
    {
    }        

    public interface IRegOp8<T> : IRegOp<W8,T>
        where T : unmanaged
    {

    }

    public interface IRegOp16<T> : IRegOp<W16,T>
        where T : unmanaged
    {

    }

    public interface IRegOp32<T> : IRegOp<W32,T>
        where T : unmanaged
    {

    }

    public interface IRegOp64<T> : IRegOp<W64,T>
        where T : unmanaged
    {

    }
}
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public interface IYmmRegOp : IRegOp<W256>
    {

    }

    public interface IYmmRegOp<S> : IYmmRegOp, IRegOp<W256,S>
        where S : unmanaged
    {            
    
    }

    public interface IYmmRegOp<F,N,S> : IYmmRegOp<S>,IRegOp<F,W256,S>
        where F : struct, IYmmRegOp<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {

    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IYmmRegOp<F,N> : IYmmRegOp<F,N,Fixed256>
        where F : struct, IYmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        
    }
}
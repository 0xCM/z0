// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public interface IZmmRegOp : IRegOp<W512>
    {
        
    }

    public interface IZmmRegOp<F,N,S> : IZmmRegOp, IRegOp<F,W512,S>
        where F : struct, IZmmRegOp<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
        
    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IZmmRegOp<F,N> : IZmmRegOp<F,N,Fixed512>
        where F : struct, IZmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        
    }
}
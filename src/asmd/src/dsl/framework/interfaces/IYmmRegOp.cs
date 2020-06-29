//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IYmmRegOp : IRegOp<W256,Fixed256>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.YMM;
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IYmmRegOp<F,R> : IYmmRegOp, IRegOp<W256,Fixed256>
        where F : struct, IYmmRegOp<F,R>
        where R : unmanaged
    {

    }    
}
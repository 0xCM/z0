//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IYmmOperand : IRegOperand<W256,Cell256>
    {
        RegisterClass IRegOperand.Class
            => RegisterClass.YMM;
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IYmmRegOperand<F,R> : IYmmOperand, IRegOperand<W256,Cell256>
        where F : struct, IYmmRegOperand<F,R>
        where R : unmanaged
    {

    }
}
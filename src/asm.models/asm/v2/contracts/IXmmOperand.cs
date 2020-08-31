//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IXmmOperand : IRegOperand<W128, FixedCell128>
    {
        RegisterClass IRegOperand.Class
            => RegisterClass.XMM;
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IXmmOperand<F,R> : IXmmOperand, IRegOperand<W128,FixedCell128>
        where F : struct, IXmmOperand<F,R>
        where R : unmanaged
    {

    }
}
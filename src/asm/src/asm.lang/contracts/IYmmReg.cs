//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IYmmReg : IRegister<W256,Cell256>
    {
        RegClass IRegister.Class
            => RegClass.YMM;
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IYmmReg<F,R> : IYmmReg, IRegister<W256,Cell256>
        where F : struct, IYmmReg<F,R>
        where R : unmanaged
    {

    }
}
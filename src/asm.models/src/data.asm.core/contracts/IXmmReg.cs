//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IXmmReg : IRegister<W128,Cell128>
    {
        RegisterClass IRegister.Class
            => RegisterClass.XMM;
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IXmmReg<F,R> : IXmmReg, IRegister<W128,Cell128>
        where F : struct, IXmmReg<F,R>
        where R : unmanaged
    {

    }
}
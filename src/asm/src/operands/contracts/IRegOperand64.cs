//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOperand64 : IRegOperand<W64,ulong>
    {
        RegisterClass IRegOperand.Class
            => RegisterClass.GP;
    }

    public interface IRegOperand64<F,T> : IRegOperand64
        where F : unmanaged, IRegOperand64<F,T>
        where T : unmanaged
    {

    }
}
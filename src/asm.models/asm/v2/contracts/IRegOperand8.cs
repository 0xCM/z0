//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOperand8 : IRegOperand<W8,byte>
    {
        RegisterClass IRegOperand.Class
            => RegisterClass.GP;
    }

    public interface IRegOperand8<F,T> : IRegOperand8
        where F : unmanaged, IRegOperand8<F,T>
        where T : unmanaged
    {

    }
}
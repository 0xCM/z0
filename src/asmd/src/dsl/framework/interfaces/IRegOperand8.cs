//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOperand8 : IRegOperand
    {
        BitSize ISized.Width 
            => 8;

        RegisterClass IRegOperand.Class 
            => RegisterClass.GP;
    }

    public interface IRegOperand8<T> : IRegOperand8, IRegOperand<W8,T>
        where T : unmanaged
    {
        BitSize ISized.Width 
            => 8;

        RegisterClass IRegOperand.Class 
            => RegisterClass.GP;

    }

    public interface IRegOperand8<F,T> : IRegOperand8<T>
        where F : unmanaged, IRegOperand8<F,T>
        where T : unmanaged
    {

    }        
}
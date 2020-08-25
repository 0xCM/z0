//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOperand16 : IRegOperand<W16,ushort>
    {
        RegisterClass IRegOperand.Class 
            => RegisterClass.GP;
    }
        
    public interface IRegOperand16<F,T> : IRegOperand16
        where F : unmanaged, IRegOperand16<F,T>
        where T : unmanaged
    {
    }    

    public interface IRegOperand16<T> : IRegOperand<W16,T>
        where T : unmanaged
    {

    }

}
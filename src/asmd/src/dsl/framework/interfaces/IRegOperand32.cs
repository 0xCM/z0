//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    public interface IRegOp32<T> : IRegOperand<W32,T>
        where T : unmanaged
    {

    }


    public interface IRegOperand32<F,T> : IRegOperand32
        where F : unmanaged, IRegOperand32<F,T>
        where T : unmanaged
    {

    }    

    public interface IRegOperand32 : IRegOperand<W32,uint>
    {
        RegisterClass IRegOperand.Class 
            => RegisterClass.GP;
    }
}
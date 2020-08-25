//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegOperand32 : IRegOperand<W32,uint>
    {
        RegisterClass IRegOperand.Class
            => RegisterClass.GP;
    }

    public interface IRegOperand32<F,T> : IRegOperand32
        where F : unmanaged, IRegOperand32<F,T>
        where T : unmanaged
    {

    }
}
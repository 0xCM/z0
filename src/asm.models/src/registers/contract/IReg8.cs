//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IReg8 : IRegister<W8,byte>
    {
        RegisterClass IRegister.Class
            => RegisterClass.GP;
    }

    public interface IReg8<F,T> : IReg8
        where F : unmanaged, IReg8<F,T>
        where T : unmanaged
    {

    }
}
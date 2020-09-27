//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IReg32 : IRegister<W32,uint>
    {
        RegisterClass IRegister.Class
            => RegisterClass.GP;
    }

    public interface IReg32<F,T> : IReg32
        where F : unmanaged, IReg32<F,T>
        where T : unmanaged
    {

    }
}
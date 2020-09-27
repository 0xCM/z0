//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IReg16 : IRegister<W16,ushort>
    {
        RegisterClass IRegister.Class
            => RegisterClass.GP;
    }

    public interface IReg16<F,T> : IReg16
        where F : unmanaged, IReg16<F,T>
        where T : unmanaged
    {
    }
}
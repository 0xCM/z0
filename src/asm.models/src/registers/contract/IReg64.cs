//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IReg64 : IRegister<W64,ulong>
    {
        RegisterClass IRegister.Class
            => RegisterClass.GP;
    }

    public interface IReg64<F,T> : IReg64
        where F : unmanaged, IReg64<F,T>
        where T : unmanaged
    {

    }
}
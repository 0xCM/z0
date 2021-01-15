//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IGpReg<W,T> : IRegister<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        RegisterClass IRegister.Class
            => RegisterClass.GP;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IReg8<T> : IReg<W8,T>
        where T : unmanaged
    {

    }

    public interface IReg8<H,T> : IReg8<T>
        where H : struct, IReg8<H,T>
        where T : unmanaged
    {

    }
}
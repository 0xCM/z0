//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IRegClass
    {
        RegClass Kind {get;}
    }

    public interface IRegClass<T> : IRegClass
        where T : unmanaged, IRegClass<T>

    {

    }
}
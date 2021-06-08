//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRegOp64 : IRegOp
    {
        RegWidth IRegOp.Width
            => RegWidth.W64;

    }

    [Free]
    public interface IRegOp64<T> : IRegOp64, IRegOp<T>
        where T : unmanaged, IRegOp64<T>
    {
        RegClass IRegOp.RegClass
            => RegClass.GP;
    }
}
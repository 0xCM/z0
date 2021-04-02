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

    }

    [Free]
    public interface IRegOp64<T> : IRegOp64, IRegOp<T>
        where T : unmanaged
    {
    }

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRegOp128 : IRegOp
    {

    }

    [Free]
    public interface IRegOp128<T> : IRegOp128, IRegOp<T>
        where T : unmanaged
    {
    }

}
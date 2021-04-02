//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRegOp512 : IRegOp
    {

    }

    [Free]
    public interface IRegOp512<T> : IRegOp512, IRegOp<T>
        where T : unmanaged
    {
    }
}
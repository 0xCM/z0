//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRegOp8 : IRegOp
    {

    }

    [Free]
    public interface IRegOp8<T> : IRegOp8, IRegOp<T>
        where T : unmanaged
    {

    }
}
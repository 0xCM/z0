//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRegOp32 : IRegOp
    {

    }

    [Free]
    public interface IRegOp32<T> : IRegOp32, IRegOp<T>
        where T : unmanaged
    {

    }
}